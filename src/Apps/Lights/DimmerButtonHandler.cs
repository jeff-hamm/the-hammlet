using System.Data;
using System.Reactive.Concurrency;
using Hammlet.Apps.SceneOnButton;
using Hammlet.Extensions;
using Hammlet.NetDaemon.Extensions;
using Hammlet.NetDaemon.Models;
using HassModel;
using NetDaemon.HassModel.Entities;

namespace Hammlet.Apps.Lights;

[NetDaemonApp]
internal class ShellyDimmerButtonHandler
{
    public ShellyDimmerButtonHandler(IHaContext ha, LightEntities entities,BinarySensorEntities buttons, 
        LightEntities lights,
        EventEntities events, ILogger<ShellyDimmerButtonHandler> logger, IScheduler scheduler)
    {
        var cfg = new DimmerButtonConfig();
        buttons.MikaelaDimmerInput0.ToButtonEvents(scheduler).Subscribe(e =>
        {
            logger.LogInformation("Button 0 Input: {0}", e.Data);
            DimmerButtonHandler(entities.MikaelaSRoom, true, e,cfg);
        });
        buttons.MikaelaDimmerInput1.ToButtonEvents(scheduler).Subscribe(e =>
        {
            logger.LogInformation("Button 1 Input: {0}", e.Data);
            DimmerButtonHandler(entities.MikaelaSRoom, false, e,cfg);
        });
        entities.MikaelaSRoom.StateAllChanges().Subscribe(s =>
        {
            if (entities.MikaelaSRoom.IsOn() && s.Entity?.EntityState?.Attributes?.Brightness is { } b)
            {
                entities.MikaelaDimmer.TurnOn(new()
                {
                    Brightness = b
                });
            }
            else
            {
                entities.MikaelaDimmer.TurnOff();
            }
        });
    }

    private static void DimmerButtonHandler(LightEntity targetEntity, bool toggleState, StateChangeEvent<ButtonEvent> e, DimmerButtonConfig config)
    {
        var multiplier = toggleState ? 1 : -1;
        if(!targetEntity.IsToggleState(toggleState))
        {
            targetEntity.ToggleState(!toggleState);
            return;
        }
        if (e.Data.EventType == ButtonEventType.Pressed)
        {
            targetEntity.Brighten(config.PressBrightness * multiplier);
        }
        if(e.Data.EventType == ButtonEventType.HeldDownTick)
        {
            targetEntity.Brighten(config.TickBrightness* multiplier);
        }
        if (e.Data.IsPressAndAHalf)
        {
            targetEntity.ToggleWarm();
        }
    }
}

public class DimmerButtonConfig
{

    public int PressBrightness { get; set; } = 20;
    public int TickBrightness { get; set; } = 2;
}