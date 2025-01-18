using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Hammlet.NetDaemon.Models;
using Hammlet.NetDaemon.Models.Framework;
using NetDaemon.HassModel.Entities;

namespace Hammlet.NetDaemon.Extensions;

public static class LightExtensions
{
    public static LightTurnOnParameters? CopyParameters(this LightEntity @this, LightEntity target) => 
        target.EntityState?.Attributes != null ? @this.CopyParameters(new ParsedLightAttributes(target.EntityState.Attributes)) : null;


    public static LightTurnOnParameters CopyParameters(this LightEntity @this, ParsedLightAttributes attributes)
    {
        if (attributes == null)
            return new();
        var supportedColorModes = @this.Attributes?.SupportedColorModes?.ParseModes()?.ToArray() ?? [];
        ColorMode mode = 
                supportedColorModes.Contains(attributes.ColorMode) ? attributes.ColorMode : ColorMode.Unknown;
        if (mode == ColorMode.Unknown && attributes.ColorMode != ColorMode.Unknown)
        {
            if (attributes.ColorMode.HasFlag(ColorMode.IsColor))
            {
                mode = supportedColorModes.FirstOrDefault(s => s.HasFlag(ColorMode.IsColor) &&
                    HasAttributes(s, attributes)
                );
            }
        }
        return new LightTurnOnParameters
        {
            Brightness = mode.HasFlag(ColorMode.Brightness) ? attributes.Brightness : null,
//            Transition = @this.Transition,
            Effect = attributes.Effect,
            White = mode == ColorMode.White ? attributes.Brightness : null,
            ColorTemp = mode == ColorMode.ColorTemp ? attributes.ColorTemp : null,
            RgbColor = mode == ColorMode.Rgb ? attributes.RgbColor as IReadOnlyCollection<int> : null,
            HsColor = mode == ColorMode.Hs ? attributes.HsColor : null,
            XyColor =  mode == ColorMode.Xy ? attributes.XyColor : null,
            RgbwColor = mode == ColorMode.Rgbw ? ToInArray(attributes.RgbwColor ) : null,
            RgbwwColor = mode == ColorMode.Rgbww ? ToInArray(attributes.RgbwColor ) : null,
        };
    }

    private static bool HasAttributes(ColorMode mode, ParsedLightAttributes attributes) =>
        mode switch
        {
            ColorMode.White => attributes.Brightness != null,
            ColorMode.ColorTemp => attributes.ColorTemp != null,
            ColorMode.Rgb => attributes.RgbColor != null,
            ColorMode.Hs => attributes.HsColor != null,
            ColorMode.Xy => attributes.XyColor != null,
            ColorMode.Rgbw => attributes.RgbwColor != null,
            ColorMode.Rgbww => attributes.RgbwColor != null,
            _ => false
        };

    private static double? ToDouble(object? value)
    {
        return value is JsonElement { ValueKind: JsonValueKind.Number } el ? el.GetDouble() : null;
    }

    private static int[]? ToInArray(object? value) => value is JsonElement element && element.ValueKind == JsonValueKind.Array ? element.EnumerateArray().Select(e => e.GetInt32()).ToArray() : null;

    private static double[]? ToArray(object? value) => value is JsonElement element && element.ValueKind == JsonValueKind.Array ? element.EnumerateArray().Select(e => e.GetDouble()).ToArray() : null;
}
public static class StateExtensions
{
    public static bool StateChangedTo<TEntity, TEntityState,TAttributes>(this StateChange<TEntity, TEntityState> @this, TEntityState state) 
        where TEntity : Entity<TEntity, EntityState<TAttributes>, TAttributes> 
        where TEntityState : EntityState<TAttributes>
        where TAttributes : class
    {
        return @this.New.State == state.State;
    }

    public static IObservable<StateChange> StateAndAttributeChanges(this Entity @this) => @this.StateAllChanges();
    public static IEnumerable<ColorMode> ParseModes(this IEnumerable<string> states) =>
        states.Select( m => m == "color_temp" ? ColorMode.ColorTemp : m.ParseState<ColorMode>()).Where(s => s != null).Select(s => s!.Value);

    public static IEnumerable<TEnum> ParseStates<TEnum>(this IEnumerable<string> states) where TEnum : struct, Enum =>
        states.Select(ParseState<TEnum>).Where(s => s != null).Select(s => s.Value);

    public static TState? ParseState<TState>(this Entity? @this) where TState : struct, Enum =>
        @this?.EntityState?.ParseState<TState>();
    public static TState? ParseState<TState>(this EntityState? @this) where TState:struct,Enum => Enum.TryParse<TState>(@this?.State, true, out var state) ? state : null;
    public static TState? ParseState<TState>(this string? @this) where TState:struct,Enum => Enum.TryParse<TState>(@this, true, out var state) ? state : null;

    //public static bool IsPlaying([NotNullWhen(true)] this IMediaPlayerEntityCore? entityState) =>
    //    entityState.IsState(MediaPlayerState.Playing);
    //public static bool IsIdle([NotNullWhen(true)] this IMediaPlayerEntityCore? entityState) =>
    //    entityState.IsState(MediaPlayerState.Idle);

    //public static bool IsState<TState>([NotNullWhen(true)] this IEntityCore? entityState, ? value) => entityState != null ?
    //        entityState.HaContext.GetState(entityState.EntityId)
    //        entityState?.State, value?.ToString(), StringComparison.OrdinalIgnoreCase);
    //string.Equals(
    //        entityState.HaContext.GetState(entityState.EntityId)
    //        entityState?.State, value?.ToString(), StringComparison.OrdinalIgnoreCase);
}
