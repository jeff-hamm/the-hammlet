using Hammlet.NetDaemon.Models;
using NetDaemon.HassModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hammlet.Apps.SceneOnButton;

namespace Hammlet.Apps.Lights;
[NetDaemonApp]
internal class LiminalDimmer
{
    public LiminalDimmer(IHaContext ha, LightEntities entities,BinarySensorEntities buttons, EventEntities events, ILogger<LiminalDimmer> logger)
    {
        buttons.LiminalDimmerChannel1Input.StateChanges().Subscribe(s =>
        {
            logger.LogInformation("1 Input: {0}", s.New?.State);
        });
        buttons.LiminalDimmerChannel2Input.StateChanges().Subscribe(s =>
        {
            logger.LogInformation("2 Input: {0}", s.New?.State);
        });
        new EventEntity(ha, "shelly.click").StateAllChanges().Subscribe(s =>
        {
            logger.LogInformation("Shelly Click: {State}, {Attributes}", s.New?.State,s.Entity.Attributes);
        });
        entities.LiminalDimmer.StateAllChanges().Subscribe(s =>
        {
            if (entities.LiminalDimmer.IsOn() && s.Entity?.EntityState?.Attributes?.Brightness is { } b)
            {
                entities.LiminalCeiling.TurnOn(new()
                {
                    Brightness = b
                });
            }
            else
            {
                entities.LiminalCeiling.TurnOff();
            }
        });
    }
}