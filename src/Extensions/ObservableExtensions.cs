using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hammlet.Apps.SceneOnButton;
using Hammlet.Extensions.Observables;
using Hammlet.Models.Base;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc.Formatters;
using NetDaemon.Extensions.Observables;
using NetDaemon.HassModel.Entities;

namespace Hammlet.Extensions;


public record EntityState<TAttributes,TData>(EntityState<TAttributes> Source, TData Data) : EntityState<TAttributes>(Source)
    where TAttributes : class
{
}

public record StateChangeEvent<TStateChange, TData>(TStateChange StateChange, TData Data) where TStateChange:StateChange;

public record StateChangeEvent<TData>(StateChange StateChange, TData Data);

public record ButtonEvent(
    ButtonEventType EventType,
    ButtonHoldingState? HoldingState = null,
    TimeSpan? ButtonHeldTime = null,
    DateTimeOffset? LastKeyDown = null,
    ButtonEventType? PendingPressState=null)
{
    public bool IsPressAndAHalf => PendingPressState != null && EventType == ButtonEventType.Down;
}

public class ButtonEventOptions
{
    //public const long DefaultDoublePressMilliseconds = DefaultPressDelay-DefaultDebounceTimeMilliseconds;
    public const long DefaultPressDelay = 500;
    public const long DefaultHoldingMilliseconds = 1000;
    public const long DefaultLongPressMilliseconds = 1000;
    public const long DefaultDebounceTimeMilliseconds = 50;

    public TimeSpan LongPressTime { get; set; } = TimeSpan.FromMilliseconds(DefaultLongPressMilliseconds);
    public TimeSpan PressDelay { get; set;} = TimeSpan.FromMilliseconds(DefaultPressDelay);
    public TimeSpan HoldDelay { get; set;} = TimeSpan.FromMilliseconds(DefaultHoldingMilliseconds);
    public TimeSpan DebounceTime { get; set; } = TimeSpan.FromMilliseconds(DefaultDebounceTimeMilliseconds);
    public TimeSpan HoldTickRate { get; set; } = TimeSpan.FromMilliseconds(500);
    public bool FireTickEvents { get; set; } = true;
}

internal sealed class ButtonEventProducer(IObservable<StateChange> source, IScheduler scheduler)
    : Producer<StateChangeEvent<ButtonEvent>, ButtonEventProducer.ButtonEventSink>
{
    protected override ButtonEventSink CreateSink(
        IObserver<StateChangeEvent<ButtonEvent>> observer) => new (observer, scheduler);

    protected override void Run(ButtonEventSink sink) => sink.Run(source);


    public class ButtonEventSink(IObserver<StateChangeEvent<ButtonEvent>> observer, IScheduler scheduler)
        : Sink<StateChange, StateChangeEvent<ButtonEvent>>(observer)
    {
        private ButtonEventOptions _options = new();
        private long _debounceStartTicks;
        private ButtonHoldingState? _holdingState;
        private DateTimeOffset? _lastKeyDown = DateTimeOffset.UtcNow;
        private DateTimeOffset? _buttonHeldStart = DateTimeOffset.UtcNow;
        private TimeSpan? _lastButtonHeldTime;
        private IDisposable? _holdingSchedule;
        private IDisposable? _howManyClicksTimer;
        private IDisposable? _holdingTicks;
        private DateTimeOffset _lastPress;
        private IDisposable? _longPressTimer;
        private bool ShouldDebounce => DateTime.UtcNow.Ticks - _debounceStartTicks < _options.DebounceTime.Ticks;

        public override void Run(IObservable<StateChange> source)
        {
            base.Run(source.DistinctUntilChanged(s => s.New?.IsOn() != true));
        }

        public override void OnNext(StateChange change)
        {
            try
            {
                if (change.New.IsOn() == true)
                {
                    HandleButtonPressed(change);
                }
                else if (change.New?.IsOff() == true)
                {
                    HandleButtonReleased(change);
                }
            }
            catch (Exception ex)
            {
                this.ForwardOnError(ex);
            }
        }



        /// <summary>
        /// Gets or sets a value indicating whether single press event is enabled or disabled on the button.
        /// </summary>
        public bool IsPressed { get; set; } = false;

        /// <summary>
        /// Handler for pressing the button.
        /// </summary>
        /// <param name="change"></param>
        protected void HandleButtonPressed(StateChange change)
        {
            if (IsPressed || ShouldDebounce)
                return;

            IsPressed = true;
            UpdateDebounce();
            _lastKeyDown = DateTimeOffset.UtcNow;
            if (_holdingState != ButtonHoldingState.Started)
            {
                if (_holdingState != ButtonHoldingState.Pending)
                {
                    _holdingState = ButtonHoldingState.Pending;
                    _holdingSchedule ??= scheduler.Schedule(change, _options.HoldDelay,
                        (_, state) =>
                        {
                            StartHolding(change);
                        });
                }
            }
            OnNext(change, ButtonEventType.Down);
        }


        public void StartHolding(StateChange change)
        {
            _buttonHeldStart = DateTimeOffset.UtcNow;
            _holdingState = ButtonHoldingState.Started;
            _holdingSchedule?.Dispose();
            OnNext(change, ButtonEventType.HeldDown);
            _holdingTicks?.Dispose();
            if (_options.FireTickEvents)
            {
                _holdingTicks = scheduler.SchedulePeriodic(change, _options.HoldTickRate, s =>
                {
                    if (_holdingState == ButtonHoldingState.Started)
                        OnNext(s, ButtonEventType.HeldDownTick);
                });
            }
            _longPressTimer?.Dispose();
            _longPressTimer = scheduler.Schedule(change, _options.LongPressTime, (_, state) =>
            {
                if (_holdingState == ButtonHoldingState.Started)
                    OnNext(change, ButtonEventType.LongPress);
            });
        }

        private void OnNext(StateChange change, ButtonEventType type)
        {
            ForwardOnNext(new StateChangeEvent<ButtonEvent>(change,
                new ButtonEvent(type, _holdingState)
                {
                    LastKeyDown = _lastKeyDown,
                    HoldingState = _holdingState,
                    PendingPressState = _nextPressType,
                    ButtonHeldTime = 
                        _holdingState switch
                        {
                            ButtonHoldingState.Started => ButtonHeldTime,
                            ButtonHoldingState.Completed => _lastButtonHeldTime,
                            _ => null
                        }
                }));
        }

        private TimeSpan? ButtonHeldTime => _buttonHeldStart.HasValue ? DateTimeOffset.UtcNow.Subtract(_buttonHeldStart.Value) : null;

        /// <summary>
        /// Handler for releasing the button.
        /// </summary>
        /// <param name="change"></param>
        protected void HandleButtonReleased(StateChange change)
        {
            ClearHoldingTimer();

            if (!IsPressed) return;
            IsPressed = false;
            UpdateDebounce();
            _lastPress = DateTimeOffset.UtcNow;
            OnNext(change, ButtonEventType.Up);
            StartPressTimer(change);
            if (_holdingState == ButtonHoldingState.Started)
            {
                _holdingState = ButtonHoldingState.Completed;
                _lastButtonHeldTime = _buttonHeldStart.HasValue ? DateTimeOffset.UtcNow.Subtract(_buttonHeldStart.Value) : null;
                OnNext(change, ButtonEventType.HoldReleased);
            }
        }

        ButtonEventType GetNextPress(ButtonEventType pressType) => (ButtonEventType)pressType + 1;
        private ButtonEventType? _nextPressType;

        private void StartPressTimer(StateChange change)
        {
            _nextPressType = _nextPressType == null ? ButtonEventType.Pressed : GetNextPress(_nextPressType.Value);
            if (_nextPressType <= ButtonEventType.Pressed3x)
            {
                _howManyClicksTimer?.Dispose();
                _howManyClicksTimer = scheduler.Schedule(_nextPressType.Value, _options.PressDelay, (type, state) =>
                {
                    OnNext(change, type);
                    _nextPressType = null;
                    _howManyClicksTimer?.Dispose();
                    _howManyClicksTimer = null;
                });
            }
        }

        private void UpdateDebounce() => _debounceStartTicks = DateTime.UtcNow.Ticks;

        private void ClearHoldingTimer()
        {
            _holdingSchedule?.Dispose();
            _holdingTicks?.Dispose();
            _longPressTimer?.Dispose();
            _longPressTimer = null;
            _holdingTicks = null;
            _holdingSchedule = null;
            _buttonHeldStart = null;
            if (_holdingState == ButtonHoldingState.Pending)
            {
                _holdingState = ButtonHoldingState.Canceled;
            }

        }

        public override void OnCompleted()
        {
            ClearHoldingTimer();
        }

        protected override void Dispose(bool disposing)
        {
            ClearHoldingTimer();
            _howManyClicksTimer?.Dispose();
            base.Dispose(disposing);
        }

    }
}

public static class ObservableExtensions
{
    

    public static IObservable<StateChangeEvent<ButtonEvent>> ToButtonEvents(
        this Entity @this, IScheduler scheduler)
    {
        
        return new ButtonEventProducer(
            @this.StateChanges(),scheduler);
    }
}
