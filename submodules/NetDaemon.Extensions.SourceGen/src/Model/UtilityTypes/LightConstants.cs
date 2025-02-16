using System;
using System.Text.Json.Serialization;

namespace Hammlet.Models.UtilityTypes
{
    public static class LightConstants
    {
        public const string DOMAIN = "light";
        public const string DATA_COMPONENT = DOMAIN;
        public const string DATA_PROFILES = DOMAIN + "_profiles";
        public static readonly TimeSpan SCAN_INTERVAL = TimeSpan.FromSeconds(30);

        public const string ATTR_COLOR_MODE = "color_mode";
        public const string ATTR_SUPPORTED_COLOR_MODES = "supported_color_modes";
        public const string ATTR_TRANSITION = "transition";
        public const string ATTR_RGB_COLOR = "rgb_color";
        public const string ATTR_RGBW_COLOR = "rgbw_color";
        public const string ATTR_RGBWW_COLOR = "rgbww_color";
        public const string ATTR_XY_COLOR = "xy_color";
        public const string ATTR_HS_COLOR = "hs_color";
        public const string ATTR_COLOR_TEMP_KELVIN = "color_temp_kelvin";
        public const string ATTR_MIN_COLOR_TEMP_KELVIN = "min_color_temp_kelvin";
        public const string ATTR_MAX_COLOR_TEMP_KELVIN = "max_color_temp_kelvin";
        public const string ATTR_COLOR_NAME = "color_name";
        public const string ATTR_WHITE = "white";
        public const string ATTR_BRIGHTNESS = "brightness";
        public const string ATTR_BRIGHTNESS_PCT = "brightness_pct";
        public const string ATTR_BRIGHTNESS_STEP = "brightness_step";
        public const string ATTR_BRIGHTNESS_STEP_PCT = "brightness_step_pct";
        public const string ATTR_PROFILE = "profile";
        public const string ATTR_FLASH = "flash";
        public const string FLASH_SHORT = "short";
        public const string FLASH_LONG = "long";
        public const string ATTR_EFFECT_LIST = "effect_list";
        public const string ATTR_EFFECT = "effect";
        public const string EFFECT_COLORLOOP = "colorloop";
        public const string EFFECT_OFF = "off";
        public const string EFFECT_RANDOM = "random";
        public const string EFFECT_WHITE = "white";

        public const int DEFAULT_MIN_KELVIN = 2000; // 500 mireds
        public const int DEFAULT_MAX_KELVIN = 6535; // 153 mireds
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LightEntityFeature
    {
        EFFECT = 4,
        FLASH = 8,
        TRANSITION = 32
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ColorMode
    {
        UNKNOWN = 0,
        ONOFF,
        BRIGHTNESS,
        COLOR_TEMP,
        HS,
        XY,
        RGB,
        RGBW,
        RGBWW,
        WHITE
    }
}
