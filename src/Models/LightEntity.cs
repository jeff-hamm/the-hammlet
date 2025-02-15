using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hammlet.Models.Enums;
using NetDaemon.HassModel.Entities;

namespace Hammlet.NetDaemon.Models;

public static class LightEntityExtensions
{
    
    public static int MaxBrightnes(this LightEntity @this) => 255;
    public static int MinBrightnes(this LightEntity @this) => 0;
    public static double? Brightness(this LightEntity @this) => 
        Double.TryParse(@this.Attributes?.Brightness?.ToString(), out var r) ? r : null;
    public static void Brightness(this LightEntity @this, int amount)
    {
        @this.TurnOn(brightness:int.Clamp(amount,0,255));
    }
    public static double? TransitionTime(this LightEntity @this) =>
        500;
    public static int? BrightenBy(this LightEntity @this, double amount, ILogger? logger=null)
    {
        var newBrightness = 255 * (amount/100.0);
        if (@this.Brightness() is { } b)
        {
            var n = int.Clamp((int)b + (int)newBrightness, 0, 255);
            logger?.LogDebug("Changing brightness {@b} by {newBrightness} to {value}", b, newBrightness,n);
            @this.TurnOn(brightness: n, transition:@this.TransitionTime());
            return n;
        }
        else
        {
            logger?.LogWarning("Brightness not available for {@entity}", @this.EntityId);
        }

        return null;
    }
    
    public static void Brighten(this LightEntity @this, double pct=20)
    {
        @this.TurnOn(brightnessStepPct: pct);
    }
    public static void Darken(this LightEntity @this, double pct=-20)
    {
        @this.TurnOn(brightnessStepPct: pct);
    }
    public static bool HasColorTemp(this LightEntity @this) =>
        @this.IsOn() && @this.Attributes is { ColorMode: ColorMode.ColorTemp } att&&
        (att.ColorTempKelvin != null || att.ColorTemp != null);

    public static void SetColorTempPct(this LightEntity @this, double colorTemp)
    {
        if (@this.Attributes?.SupportedColorModes?.Contains(ColorMode.ColorTemp) == true)
        {
            if (@this.Attributes is { MinColorTempKelvin: { } minK, MaxColorTempKelvin: { } maxK})
            {
                var dst = ((maxK - minK) * colorTemp) + minK;
                @this.TurnOn(kelvin:dst);
            }
            else if (@this.Attributes is { MinMireds: { } min, MaxMireds: { } max })
            {
                var dst = ((max - min) * colorTemp) + min;
                @this.TurnOn(colorTemp: dst);
            }
        }
    }
    public static bool IsWarm(this LightEntity @this) =>
        @this.ColorTempPct() is < .5;
    public static double? ColorTempPct(this LightEntity @this)
    {
        try
        {
            if (!@this.HasColorTemp())
                return null;
            var att = @this.Attributes!;
            if (att.ColorTempKelvin is { } k && att is { MinColorTempKelvin: { } minK, MaxColorTempKelvin: { } maxK })
            {
                return (k - minK) / (maxK - minK);
            }

            if (att.ColorTemp is { } colorTemp && att is { MinMireds: { } min, MaxMireds: { } max })
            {
                return (colorTemp - min) / (max - min);
            }

            return null;
        }
        catch (Exception e)
        {

            throw;
        }
    }

    public static void MakeWarm(this LightEntity @this)
    {
        if (!@this.IsWarm())
        {
            @this.SetColorTempPct(.1);
        }
    }

    public static void ToggleWarm(this LightEntity @this)
    {
        if (!@this.IsOn()) return;
        double dstColorTempPct = .1;
        if (@this.IsWarm())
        {
            @this.SetColorTempPct(.9);
        }
        else
        {
            @this.SetColorTempPct(.1);
        }
        //if (att is { MinMireds: { } min, MaxMireds: { } max })
        //{
        //    if (a.ColorMode is ColorMode.ColorTemp && att.ColorTemp is { } colorTemp)
        //    {
        //        var colorTempPct = (colorTemp - min) / (max - min);
        //        if (colorTempPct < .5)
        //        {
        //            dstColorTempPct = .9;
        //        }
        //        else
        //        {
        //            dstColorTempPct = .1;
        //        }
        //    }

        //    var dst = ((max - min) * dstColorTempPct) + min;
        //    @this.TurnOn(colorTemp: dst);
        //}
        //else if (att is { MinColorTempKelvin: { } minK, MaxColorTempKelvin: { } maxK })
        //{
        //    if (a.ColorMode is ColorMode.ColorTemp && att.ColorTemp is { } colorTemp)
        //    {
        //        var colorTempPct = (colorTemp - minK) / (maxK - minK);
        //        if (colorTempPct < .5)
        //        {
        //            dstColorTempPct = .9;
        //        }
        //        else
        //        {
        //            dstColorTempPct = .1;
        //        }
        //    }

        //    var dst = ((maxK - minK) * dstColorTempPct) + minK;
        //    @this.TurnOn(kelvin:dst);
        //}


    }
}

public record SafeEntityState<TAttributes> : EntityState<TAttributes> where TAttributes:class
{
    public static readonly JsonSerializerOptions DefaultJsonSerializerOptions = new(JsonSerializerDefaults.Web)
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        Converters = { new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower) }
    };
    private readonly Lazy<TAttributes?> _attributesLazy;

    public SafeEntityState(EntityState state) : base(state)
    {
        this._attributesLazy = new Lazy<TAttributes?>((Func<TAttributes>)(() =>
        {
            var attributesJson = this.AttributesJson;
            try
            {
                return (attributesJson.HasValue
                    ? attributesJson.GetValueOrDefault()
                        .Deserialize<TAttributes>(
                        DefaultJsonSerializerOptions
                        )
                    : default(TAttributes)) ?? default(TAttributes);
            }
            catch (Exception e)
            {
                return null;
            }
        }));
    }


    /// <inheritdoc />
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public override TAttributes? Attributes => _attributesLazy.Value;
}
public partial record LightEntity
{
    public const double WarmLightPct = 0.1;
    public const double CoolLightPct = 0.1;


    private EntityState<LightAttributes>? _state;

    public override EntityState<LightAttributes>? EntityState => 
        
        _state ??= 
            this.HaContext.GetState(this.EntityId) is {} s ?
            new SafeEntityState<LightAttributes>(s) : null;
}