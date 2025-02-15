using Hammlet.NetDaemon.Models;

namespace Hammlet.Config;

public class DimmerSync
{
    public string DimmerId { get; set; } = LightEntities.Ids.LiminalDimmer;

    public int PressBrightness { get; set; } = 20;
    public int TickBrightness { get; set; } = 10;
    public string TargetLightId { get; set; } = LightEntities.Ids.LiminalCeiling;
    public string? UpButtonId { get; set; }
    public string? DownButtonId { get; set; }
}