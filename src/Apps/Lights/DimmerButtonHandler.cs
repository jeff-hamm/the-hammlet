using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Concurrency;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Hammlet.Apps.SceneOnButton;
using Hammlet.Config;
using Hammlet.Extensions;
using Hammlet.NetDaemon.Extensions;
using Hammlet.NetDaemon.Models;
using HassModel;
using NetDaemon.Client.HomeAssistant.Model;
using NetDaemon.HassModel.Entities;

namespace Hammlet.Apps.Lights;

[NetDaemonApp]
internal class ShellyDimmerButtonHandler : IAsyncInitializable
{
    private readonly IAsyncHaContext _ha;
    private ILogger<ShellyDimmerButtonHandler> _logger;
    private readonly IScheduler _scheduler;
    private readonly DimmerSync _cfg;

    public ShellyDimmerButtonHandler(IAsyncHaContext ha, ILogger<ShellyDimmerButtonHandler> logger, IScheduler scheduler, IAppConfig<DimmerSync> appCfg)
    {
        _ha = ha;
        _logger= logger;
        _scheduler = scheduler;
        _cfg = appCfg.Value;
        var cfg = appCfg.Value;
        var srcDimmer = ha.LightEntity(cfg.DimmerId);
        var upButton = ha.BinarySensor(cfg.UpButtonId ?? cfg.DimmerId + "_input_0");
        var downButton = ha.BinarySensor(cfg.DownButtonId ?? cfg.DimmerId + "_input_1");
        logger.LogDebug("Subscribing to buttonEvents from {dimmer} [{upButton} & {downButton}] to control {targetLightId}", 
            srcDimmer.EntityId,
            upButton.EntityId, downButton.EntityId, cfg.TargetLightId);
        IDisposable? t = null;
        upButton
            .ToButtonEvents(scheduler)
            .Subscribe(e =>
        {
            logger.LogInformation("Button 0 Input: {@0}", e.Data);
            var targetEntity = ha.LightEntity(cfg.TargetLightId);
            if(!targetEntity.IsOn())
            {
                targetEntity.TurnOn();
                return;
            }
            if (e.Data.IsPressAndAHalf)
            {
                SetBrightness(255);
//                targetEntity.MaxBrightnes();
            }
            DimmerButtonHandler(ha.LightEntity(cfg.DimmerId), targetEntity, true, e, cfg);
        });
        downButton.ToButtonEvents(scheduler).Subscribe(e =>
        {
            logger.LogInformation("Button 1 Input: {@0}", e.Data);
            var targetEntity = ha.LightEntity(cfg.TargetLightId);
            if (e.Data.IsPressAndAHalf)
            {
                targetEntity.ToggleWarm();
            }
            DimmerButtonHandler(ha.LightEntity(cfg.DimmerId), targetEntity, false, e, cfg);
        });
        //ha.LightEntity(cfg.TargetLightId).StateAllChanges().Subscribe(s =>
        //{
        //    if(t != null) return;
        //    logger.LogDebug("Back-Reference updating dimmer brightness to {b}", s.Entity?.EntityState?.Attributes?.Brightness);
        //    if (s.Entity.IsOn() && s.Entity?.EntityState?.Attributes?.Brightness is { } b)
        //    {
        //        ha.LightEntity(cfg.DimmerId).TurnOn(new()
        //        {
        //            Brightness = b
        //        });
        //    }
        //    else
        //        ha.LightEntity(cfg.DimmerId).TurnOff();
        //});
    }

    //private void ToggleWarm(LightEntity @this)
    //{
    //    if (!@IsOn()) return;
    //    double dstColorTempPct = .1;
    //    if (@IsWarm())
    //    {
    //        dst = dst with
    //        {

    //        }
    //        @SetColorTempPct(.9);
    //    }
    //    else
    //    {
    //        @SetColorTempPct(.1);
    //    }
    //}

    private void DimmerButtonHandler(LightEntity srcBrightness, LightEntity targetEntity, bool toggleState, StateChangeEvent<ButtonEvent> e, DimmerSync config)
    {
        if (targetEntity.IsToggleState(!toggleState))
        {
            SetState(toggleState);
            return;
        }
        var multiplier = toggleState ? 1 : -1;
        if (e.Data.EventType == ButtonEventType.Pressed)
        {
            if (targetEntity.Brightness() is { } b)
            {
                var newBrightness = b.Brighten(config.PressBrightness * multiplier);
                SetBrightness(newBrightness);
            }
        }
        else if(e.Data.EventType == ButtonEventType.HeldDown)
        {
            SetDimming(config.TickBrightness*multiplier);
        } 
        else if (e.Data.EventType == ButtonEventType.HoldReleased)
        {
            SetDimming((config.TickBrightness * multiplier)*-1);
        }
    }

    private void SetState(bool state)
    {
        DstState = DstState with
        {
            State = state
        };
        _loopTokenSource?.Cancel();
    }
    private void SetDimming(int newBrightness)
    {
        DstState = DstState with
        {
            Dimming = newBrightness
        };
        _loopTokenSource?.Cancel();
    }

    private void SetBrightness(int newBrightness)
    {
        DstState = DstState with
        {
            Brightness = newBrightness
        };
        _loopTokenSource?.Cancel();
    }

    public bool Enabled { get; set; }

    private record Desiredstate(bool? State = null, int? Brightness = null, int? ColorTemp = null, int? Dimming = null);

    private CancellationTokenSource? _loopTokenSource;
    public int LoopDelay { get; set; }  = 1000;
    private Desiredstate DstState { get; set; } = new Desiredstate();
    public async Task InitializeAsync(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                var token = NewLoop(cancellationToken);
                var dst = DstState;
                if(!Enabled ||
                       _ha.LightEntity(_cfg.TargetLightId) is not { } entity ||
                       (entity.EntityState.IsOn() == dst.State &&
                        (!TryParseAttributes(entity.EntityState, out var attr) ||
                         !NeedsTransition(attr, dst)))
                      )
                {
                    await Task.Delay(LoopDelay, token);
                    continue;
                }

                if (dst.State == false)
                {
                    await CallServiceAsyc(entity, "turn_off", new LightTurnOffParameters(),
                        cancellationToken);
                    DstState = new();
                    continue;
                }
                var (k, r) =
                    dst.ColorTemp.HasValue ? entity.GetColorTempFromPct(dst.ColorTemp.Value) : (null,null);
                var newBrightness = 
                        (int)(dst.Brightness ?? entity.Attributes?.Brightness ?? 0) + 
                                    (dst.Dimming ?? 0);
                if (newBrightness <= 0)
                {
                    await CallServiceAsyc(entity, "turn_off", new LightTurnOffParameters(),
                        cancellationToken);
                    DstState = new();
                    continue;
                }
                await CallServiceAsyc(entity,"turn_on",new LightTurnOnParameters()
                {
                    Kelvin = k,
                    ColorTemp = r,
                    Brightness = Int32.Clamp(newBrightness,0,255)
                }, cancellationToken);
                dst = new()
                {
                    Dimming = dst.Dimming
                };
                LoopDelay = dst.Dimming.HasValue && dst.Dimming != 0 ? _cfg.DimmerDelay : 2000;
            }
            finally
            {
                _loopTokenSource?.Dispose();
                _loopTokenSource = null;
            }


        }
    }
    public Task CallServiceAsyc(IEntityCore entity, string service, object? data = null, CancellationToken? token=null)
    {
        ArgumentNullException.ThrowIfNull(entity);
        ArgumentNullException.ThrowIfNull(service);

        var (serviceDomain, serviceName) = service.SplitAtDot();

        serviceDomain ??= entity.EntityId.SplitAtDot().Left ?? throw new InvalidOperationException("EntityId must be formatted 'domain.name'");

        return _ha.CallServiceAsync(serviceDomain, 
            serviceName,
            data,
            new HassTarget()
            {
                EntityIds = new string[] {entity.EntityId}
            },
            token);
    }

    private CancellationToken NewLoop(CancellationToken cancellationToken)
    {
        _loopTokenSource?.Dispose();
        _loopTokenSource = null;
        _loopTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        return _loopTokenSource.Token;
        
    }

    private bool NeedsTransition(LightAttributes a, Desiredstate dst)
    {

        return 
            dst.Brightness.HasValue && ((int?)a.Brightness) != dst.Brightness ||
               dst.ColorTemp.HasValue && ((int?)a.ColorTempPct()) != dst.ColorTemp;
    }

    private bool TryParseAttributes(EntityState? state,[NotNullWhen(true)] out LightAttributes? a)
    {
        a = state?.AttributesJson?.Deserialize<LightAttributes>(HassJsonContext.DefaultOptions);
        if (a == null)
        {
            _logger.LogError("Attributes missing for entity {@entity}", state.EntityId);
            return false;
        }

        return true;
    }
}