﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Vogen;

namespace Hammlet.NetDaemon.Models.Framework;
public enum HaStates : int
{
    Unknown,
    Unavailable,
    On,
    Off
}


[JsonConverter(typeof(JsonStringEnumConverter)),Flags]
public enum ColorMode
{
    Unknown,        // The light's color mode is not known.
    Brightness         = 0b0001,
    IsColor            = 0b0010,     // The light can be turned on or off. This mode must be the only supported mode if supported by the light.
    IsOneDigit         = 0b0100,
    IsTwoDigits        = 0b1000,
    IsRgb             = 0b10000,
    [JsonStringEnumMemberName("color_temp")]
    ColorTemp          = 0b0101,     // The light can be dimmed and its color temperature is present in the state.
    Hs                 = 0b1011,     // The light can be dimmed and its color can be adjusted. The light's brightness can be set using the brightness parameter and read through the brightness property. The light's color can be set using the hs_color parameter and read through the hs_color property. hs_color is an (h, s) tuple (no brightness).
    Xy                 = 0b1111,      // The light can be dimmed and its color can be adjusted. The light's brightness can be set using the brightness parameter and read through the brightness property. The light's color can be set using the xy_color parameter and read through the xy_color property. xy_color is an (x, y) tuple.
    Rgb               = 0b10011,            // The light can be dimmed and its color can be adjusted. The light's brightness can be set using the brightness parameter and read through the brightness property. The light's color can be set using the rgb_color parameter and read through the rgb_color property. rgb_color is an (r, g, b) tuple (not normalized for brightness).
    Rgbw             = 0b110011,           // The light can be dimmed and its color can be adjusted. The light's brightness can be set using the brightness parameter and read through the brightness property. The light's color can be set using the rgbw_color parameter and read through the rgbw_color property. rgbw_color is an (r, g, b, w) tuple (not normalized for brightness).
    Rgbww           = 0b1110011,// The light can be dimmed and its color can be adjusted. The light's brightness can be set using the brightness parameter and read through the brightness property. The light's color can be set using the rgbww_color parameter and read through the rgbww_color property. rgbww_color is an (r, g, b, cw, ww) tuple (not normalized for brightness).
    White          = 0b10000000// The light can be dimmed and its color can be adjusted. In addition, the light can be set to white mode. The light's brightness can be set using the brightness parameter and read through the brightness property. The light can be set to white mode by using the white parameter with the desired brightness as value. Note that there's no white property. If both brighthness and white are present in a service action call, the white parameter will be updated with the value of brightness. If this mode is supported, the light must also support at least one of ColorMode.HS, ColorMode.RGB, ColorMode.RGBW, ColorMode.RGBWW or ColorMode.XY and must not support ColorMode.COLOR_TEMP.
}
public enum MediaPlayerStates : int
{
    Unknown = HaStates.Unknown,
    Unavailable = HaStates.Unavailable,
    On = HaStates.On,
    Off = HaStates.Off,
    Idle,
    Playing,
    Paused,
    Standby,
    Buffering
}


public static class EnumExt
{
    public static TEnum? TryParse<TEnum>(string? value) where TEnum : struct,Enum => Enum.TryParse<TEnum>(value,true, out var v) ? v : default;
    public static Validation Validate<TEnum>(string? value) where TEnum : struct,Enum =>
        Enum.TryParse<TEnum>(value, out var v) ? Validation.Ok : Validation.Invalid($"Invalid {typeof(TEnum)} value {value}");

}


[ValueObject(typeof(string))]
public partial class HaState : IEnumValue<HaStates>
{
    static Validation Validate(string value) => IEnumValue<HaStates>.Validate(value);

    public bool Equals(HaStates other) => this.Equals(other.ToString());
}

public interface IEnumValue<TEnum> : IEquatable<TEnum>
    where TEnum : struct,Enum
{
    public TEnum? EnumValue => EnumExt.TryParse<TEnum>(Value);

    string? Value { get; }

    static Validation Validate(string value) => EnumExt.Validate<TEnum>(value);
}


//public enum MediaPlayerState : State
//{
//    Playing,
//    Paused,
//    Idle
//}