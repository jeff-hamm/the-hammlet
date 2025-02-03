using Hammlet.Models.Enums;
using Hammlet.NetDaemon.Models;
using NetDaemon.HassModel.Entities;

namespace HassModel;

public static class EventExtensions
{
    public static IObservable<Event> Event(this EventEntity @this) =>
        @this.HaContext.Event(@this);
    public static IObservable<Event> Event(this IHaContext @this, EventEntity entity) =>
        @this.Events.Where(e => e.EventType == entity.EntityId);

    public static string? EventType(this EventEntity @this) => @this.Attributes?.EventType;
    public static TEnum? EventType<TEnum>(this EventEntity @this)
        where TEnum : struct
        => Enum.TryParse<TEnum>(@this.Attributes?.EventType, out var r) ? r : null;
    public static void PrintEntityInfo(this Entity? entity)
    {
        if (entity == null)
        {
            Console.WriteLine("Entity is null");
            return;
        }
        Console.WriteLine($"Info: {entity.EntityId}");
        Console.WriteLine(entity.ToString());
        Console.WriteLine(entity.HaContext.GetState(entity.EntityId)?.ToString());
        Console.WriteLine(entity.Attributes?.ToString());
        Console.WriteLine("Registration");
        Console.WriteLine(entity.Registration);
        Console.WriteLine("Device");
        Console.WriteLine(entity.Registration?.Device);
    }

    public static int MaxBrightnes(this LightEntity @this) => 255;
    public static int MinBrightnes(this LightEntity @this) => 0;
    public static double? Brightness(this LightEntity @this) => 
        Double.TryParse(@this.Attributes?.Brightness?.ToString(), out var r) ? r : null;
    
    //public static double Brightness(this LightEntity @this, double newValue)
    //{
    //    if (@this.Brightness() != null)
    //    {
    //        @this.Attributes.Brightness = Math.Clamp(newValue, @this.MinBrightnes(), @this.MaxBrightnes());
    //    }
    //}

    public static void Brighten(this LightEntity @this, double pct=20)
    {
        @this.TurnOn(brightnessStepPct: pct);
        //if (!@this.IsOn())
        //{
        //    @this.TurnOn();
        //}
        //var currentBrightness =@this.Brightness() ?? 50;
        //@this.Brightness(currentBrightness + 5);
    }
    public static void Darken(this LightEntity @this, double pct=-20)
    {
        @this.TurnOn(brightnessStepPct: pct);

    }

    public static void ToggleWarm(this LightEntity @this)
    {
        if (@this.EntityState?.Attributes is not { } att) return;
        ParsedLightAttributes a = new ParsedLightAttributes(att);
        double dstColorTempPct = .1;
        if (att is { MinMireds: { } min, MaxMireds: { } max })
        {
            if (a.ColorMode is ColorMode.ColorTemp && att.ColorTemp is { } colorTemp)
            {
                var colorTempPct = (colorTemp - min) / (max - min);
                if (colorTempPct < .5)
                {
                    dstColorTempPct = .9;
                }
                else
                {
                    dstColorTempPct = .1;
                }
            }

            var dst = ((max - min) * dstColorTempPct) + min;
            @this.TurnOn(colorTemp: dst);
        }
        else if (att is { MinColorTempKelvin: { } minK, MaxColorTempKelvin: { } maxK })
        {
            if (a.ColorMode is ColorMode.ColorTemp && att.ColorTemp is { } colorTemp)
            {
                var colorTempPct = (colorTemp - minK) / (maxK - minK);
                if (colorTempPct < .5)
                {
                    dstColorTempPct = .9;
                }
                else
                {
                    dstColorTempPct = .1;
                }
            }

            var dst = ((maxK - minK) * dstColorTempPct) + minK;
            @this.TurnOn(kelvin:dst);
        }


    }
}