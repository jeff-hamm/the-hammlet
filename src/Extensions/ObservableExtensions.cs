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
    DateTimeOffset? LastKeyDown = null);

internal sealed class ButtonEventProducer(IObservable<StateChange> source, IScheduler scheduler)
    : Producer<StateChangeEvent<ButtonEvent>, ButtonEventProducer.ButtonEventSink>
{
    protected override ButtonEventSink CreateSink(
        IObserver<StateChangeEvent<ButtonEvent>> observer) => new (observer, scheduler);

    protected override void Run(ButtonEventSink sink) => sink.Run(source);

    public class ButtonEventSink(IObserver<StateChangeEvent<ButtonEvent>> observer, IScheduler scheduler)
        : Sink<StateChange, StateChangeEvent<ButtonEvent>>(observer)
    {
        internal const long DefaultDoublePressMilliseconds = DefaultPressDelay-DefaultDebounceTimeMilliseconds;
        internal const long DefaultPressDelay = 250;
        internal const long DefaultHoldingMilliseconds = 2000;
        public const long DefaultDebounceTimeMilliseconds = 50;

        private readonly TimeSpan _doublePressTicks = TimeSpan.FromMilliseconds(DefaultDoublePressMilliseconds);
        private readonly TimeSpan _pressDelay = TimeSpan.FromMilliseconds(DefaultPressDelay);
        private readonly TimeSpan _holdDelay = TimeSpan.FromMilliseconds(DefaultHoldingMilliseconds);
        private readonly TimeSpan _debounceTime = TimeSpan.FromMilliseconds(DefaultDebounceTimeMilliseconds);

        private long _debounceStartTicks;
        private ButtonHoldingState? _holdingState;
        private DateTimeOffset? _lastKeyDown = DateTimeOffset.UtcNow;
        private DateTimeOffset? _buttonHeldStart = DateTimeOffset.UtcNow;
        private TimeSpan? _buttonHeldTime;
        private DateTimeOffset? _lastPress;
        private IDisposable? _holdingSchedule;
        private IDisposable? _pressDelaySchedule;
        private bool ShouldDebounce => DateTime.UtcNow.Ticks - _debounceStartTicks < _debounceTime.Ticks;

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
                    _holdingSchedule ??= scheduler.Schedule(change, _holdDelay,
                        (_, state) =>
                        {
                            _buttonHeldStart = DateTimeOffset.UtcNow;
                            _holdingState = ButtonHoldingState.Started;
                            _holdingSchedule?.Dispose();
                            _holdingSchedule = null;
                            OnNext(change, ButtonEventType.HeldDown);
                        });
                }
            }

            OnNext(change, ButtonEventType.ButtonDown);

        }

        private void OnNext(StateChange change, ButtonEventType type)
        {
            ForwardOnNext(new StateChangeEvent<ButtonEvent>(change,
                new ButtonEvent(type, _holdingState)
                {
                    LastKeyDown = _lastKeyDown,
                    HoldingState = _holdingState,
                    ButtonHeldTime = 
                        _holdingState switch
                        {
                            ButtonHoldingState.Started =>_buttonHeldStart.HasValue ? DateTimeOffset.UtcNow.Subtract(_buttonHeldStart.Value) : null,
                            ButtonHoldingState.Completed => _buttonHeldTime,
                            _ => null
                        }
                }));
        }

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
            OnNext(change, ButtonEventType.ButtonReleased);
            _pressDelaySchedule = scheduler.Schedule(change, _pressDelay, (_, state) =>
            {
                OnNext(change, ButtonEventType.ButtonPressed);
            });
            if (_holdingState == ButtonHoldingState.Started)
            {
                _holdingState = ButtonHoldingState.Completed;
                _buttonHeldTime = _buttonHeldStart.HasValue ? DateTimeOffset.UtcNow.Subtract(_buttonHeldStart.Value) : null;
                OnNext(change, ButtonEventType.HeldButtonReleased);
            }
        }

        private void UpdateDebounce() => _debounceStartTicks = DateTime.UtcNow.Ticks;

        private void ClearHoldingTimer()
        {
            _holdingSchedule?.Dispose();
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
