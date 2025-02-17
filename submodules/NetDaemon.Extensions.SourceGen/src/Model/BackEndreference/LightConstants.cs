using System;
using System.Text.Json.Serialization;

namespace Hammlet.Models.BackEnd
{
    public static class LightConstants
    {
        public const string Domain = "light";
        public const string DataComponent = Domain;
        public const string DataProfiles = Domain + "_profiles";
        public static readonly TimeSpan ScanInterval = TimeSpan.FromSeconds(30);

        public const string AttrColorMode = "color_mode";
        public const string AttrSupportedColorModes = "supported_color_modes";
        public const string AttrTransition = "transition";
        public const string AttrRgbColor = "rgb_color";
        public const string AttrRgbwColor = "rgbw_color";
        public const string AttrRgbwwColor = "rgbww_color";
        public const string AttrXyColor = "xy_color";
        public const string AttrHsColor = "hs_color";
        public const string AttrColorTempKelvin = "color_temp_kelvin";
        public const string AttrMinColorTempKelvin = "min_color_temp_kelvin";
        public const string AttrMaxColorTempKelvin = "max_color_temp_kelvin";
        public const string AttrColorName = "color_name";
        public const string AttrWhite = "white";
        public const string AttrBrightness = "brightness";
        public const string AttrBrightnessPct = "brightness_pct";
        public const string AttrBrightnessStep = "brightness_step";
        public const string AttrBrightnessStepPct = "brightness_step_pct";
        public const string AttrProfile = "profile";
        public const string AttrFlash = "flash";
        public const string FlashShort = "short";
        public const string FlashLong = "long";
        public const string AttrEffectList = "effect_list";
        public const string AttrEffect = "effect";
        public const string EffectColorloop = "colorloop";
        public const string EffectOff = "off";
        public const string EffectRandom = "random";
        public const string EffectWhite = "white";

        public const int DefaultMinKelvin = 2000; // 500 mireds
        public const int DefaultMaxKelvin = 6535; // 153 mireds
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [SnakeCaseEnum]
    public enum LightEntityFeature
    {
        Effect = 4,
        Flash = 8,
        Transition = 32
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [SnakeCaseEnum]
    public enum ColorMode
    {
        Unknown = 0,
        Onoff,
        Brightness,
        ColorTemp,
        Hs,
        Xy,
        Rgb,
        Rgbw,
        Rgbww,
        White
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [SnakeCaseEnum]
    public enum LightAttributes
    {
        ColorMode,
        SupportedColorModes,
        Transition,
        RgbColor,
        RgbwColor,
        RgbwwColor,
        XyColor,
        HsColor,
        ColorTempKelvin,
        MinColorTempKelvin,
        MaxColorTempKelvin,
        ColorName,
        White,
        Brightness,
        BrightnessPct,
        BrightnessStep,
        BrightnessStepPct,
        Profile,
        Flash,
        EffectList,
        Effect,
        MinMireds,
        MaxMireds,
        ColorTemp
    }
}