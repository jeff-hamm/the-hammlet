using Hammlet.NetDaemon.Models;
using NetDaemon.HassModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hammlet.Apps.Lights;
[NetDaemonApp]
internal class LiminalDimmer
{
    public LiminalDimmer(IHaContext ha, LightEntities entities)
    {

        entities.OfficeDimmer.StateAllChanges().Subscribe(s =>
        {
            if (entities.OfficeDimmer.IsOn() && s.Entity?.EntityState?.Attributes?.Brightness is { } b)
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