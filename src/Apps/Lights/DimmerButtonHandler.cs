using System.Data;
using System.Reactive.Concurrency;
using Hammlet.Apps.SceneOnButton;
using Hammlet.Config;
using Hammlet.Extensions;
using Hammlet.NetDaemon.Extensions;
using Hammlet.NetDaemon.Models;
using HassModel;
using NetDaemon.HassModel.Entities;

namespace Hammlet.Apps.Lights;

[NetDaemonApp]
internal class ShellyDimmerButtonHandler
{
    private ILogger<ShellyDimmerButtonHandler> _logger;
    public ShellyDimmerButtonHandler(IHaContext ha, ILogger<ShellyDimmerButtonHandler> logger, IScheduler scheduler, IAppConfig<DimmerSync> appCfg)
    {
        _logger= logger;
        var cfg = appCfg.Value;
        var srcDimmer = ha.LightEntity(cfg.DimmerId);
        var upButton = ha.BinarySensor(cfg.UpButtonId ?? cfg.DimmerId + "_input_0");
        var downButton = ha.BinarySensor(cfg.DownButtonId ?? cfg.DimmerId + "_input_1");
        logger.LogDebug("Subscribing to buttonEvents from {dimmer} [{upButton} & {downButton}] to control {targetLightId}", 
            srcDimmer.EntityId,
            upButton.EntityId, downButton.EntityId, cfg.TargetLightId);
        IDisposable? t = null;
        upButton.CallServiceWithResponseAsync()
            .ToButtonEvents(scheduler)
            .SubscribeOn()
            .Subscribe(e =>
        {
            logger.LogInformation("Button 0 Input: {@0}", e.Data);
            var targetEntity = ha.LightEntity(cfg.TargetLightId);
            if(!targetEntity.IsOn())
            {
                targetEntity.TurnOn();
                return;
            }

            if (DimmerButtonHandler(ha.LightEntity(cfg.DimmerId),targetEntity, true, e, cfg) is { } r)
            {
                t = scheduler.Schedule(r, r, (_, __) =>
                {
                    t?.Dispose();
                    t = null;
                });
            }
        });
        downButton.ToButtonEvents(scheduler).Subscribe(e =>
        {
            logger.LogInformation("Button 1 Input: {@0}", e.Data);
            if (DimmerButtonHandler(ha.LightEntity(cfg.DimmerId),ha.LightEntity(cfg.TargetLightId), false, e, cfg) is { } r)
            {
                t = scheduler.Schedule(r, r, (_, __) =>
                {
                    t?.Dispose();
                    t = null;
                });
            }
        });
        ha.LightEntity(cfg.TargetLightId).StateAllChanges().Subscribe(s =>
        {
            if(t != null) return;
            logger.LogDebug("Back-Reference updating dimmer brightness to {b}", s.Entity?.EntityState?.Attributes?.Brightness);
            if (s.Entity.IsOn() && s.Entity?.EntityState?.Attributes?.Brightness is { } b)
            {
                ha.LightEntity(cfg.DimmerId).TurnOn(new()
                {
                    Brightness = b
                });
            }
            else
                ha.LightEntity(cfg.DimmerId).TurnOff();
        });
    }

    private TimeSpan? DimmerButtonHandler(LightEntity srcBrightness, LightEntity targetEntity, bool toggleState, StateChangeEvent<ButtonEvent> e, DimmerSync config)
    {
        var multiplier = toggleState ? 1 : -1;
        if (e.Data.EventType == ButtonEventType.Pressed)
        {

            if (targetEntity.BrightenBy(config.PressBrightness * multiplier, _logger) is { } t)
            {
                srcBrightness.Brightness(t);
                return TimeSpan.FromMilliseconds(500);
            }
        }
        if(e.Data.EventType == ButtonEventType.HeldDownTick)
        {
            if(targetEntity.BrightenBy(config.TickBrightness* multiplier,_logger) is { } t)
            {
                srcBrightness.Brightness(t);
                return TimeSpan.FromMilliseconds(500);
            }
        } 
        if (e.Data.IsPressAndAHalf)
        {
            targetEntity.ToggleWarm();
            return TimeSpan.FromMilliseconds(500);
        }

        return null;
    }
}