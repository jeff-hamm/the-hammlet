using Hammlet.NetDaemon.Models;
using NetDaemon.HassModel.Entities;

namespace Hammlet.Apps.Lights;
[NetDaemonApp]
internal class LiminalDimmer
{
    public LiminalDimmer(IHaContext ha, LightEntities entities,BinarySensorEntities buttons, EventEntities events, ILogger<LiminalDimmer> logger)
    {
        //buttons.LiminalDimmerInput0.StateChanges().Subscribe(s =>
        //{
        //    logger.LogInformation("1 Input: {0}", s.New?.State);
        //});
        //buttons.LiminalDimmerInput1.StateChanges().Subscribe(s =>
        //{
        //    logger.LogInformation("2 Input: {0}", s.New?.State);
        //});
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