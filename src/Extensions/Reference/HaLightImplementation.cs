using System;
using System.Collections.Generic;

public class LightEntity : ToggleEntity
{
    // Attributes
    private static readonly HashSet<string> _entityComponentUnrecordedAttributes = new HashSet<string>
    {
        "supported_color_modes",
        "effect_list",
        "min_mireds",
        "max_mireds",
        "min_color_temp_kelvin",
        "max_color_temp_kelvin",
        "brightness",
        "color_mode",
        "color_temp",
        "color_temp_kelvin",
        "effect",
        "hs_color",
        "rgb_color",
        "rgbw_color",
        "rgbww_color",
        "xy_color",
    };

    public LightEntityDescription EntityDescription { get; set; }
    public int? Brightness { get; set; }
    public string? ColorMode { get; set; }
    public int? ColorTempKelvin { get; set; }
    public List<string>? EffectList { get; set; }
    public string? Effect { get; set; }
    public Tuple<float, float>? HsColor { get; set; }
    public int? MaxColorTempKelvin { get; set; }
    public int? MinColorTempKelvin { get; set; }
    public Tuple<int, int, int>? RgbColor { get; set; }
    public Tuple<int, int, int, int>? RgbwColor { get; set; }
    public Tuple<int, int, int, int, int>? RgbwwColor { get; set; }
    public HashSet<string>? SupportedColorModes { get; set; }
    public LightEntityFeature SupportedFeatures { get; set; } = new LightEntityFeature(0);
    public Tuple<float, float>? XyColor { get; set; }

    // Deprecated attributes
    public readonly int? ColorTemp = null;
    public readonly int MaxMireds = 500; // = 2000 K
    public readonly int MinMireds = 153; // = 6535.94 K (~ 6500 K)

    private bool _colorModeReported = false;

    // Methods
    public string GetInternalColorMode()
    {
        if (ColorMode == null)
        {
            if (!_colorModeReported)
            {
                _colorModeReported = true;
                // Log warning
            }
            var supported = GetInternalSupportedColorModes();

            if (supported.Contains("hs") && HsColor != null) return "hs";
            if (supported.Contains("color_temp") && ColorTempKelvin != null) return "color_temp";
            if (supported.Contains("brightness") && Brightness != null) return "brightness";
            if (supported.Contains("onoff")) return "onoff";
            return "unknown";
        }
        return ColorMode;
    }

    public int? GetColorTempKelvin()
    {
        if (ColorTempKelvin == null && ColorTemp != null)
        {
            // Log usage
            return ColorUtil.ColorTemperatureMiredToKelvin(ColorTemp.Value);
        }
        return ColorTempKelvin;
    }

    public int GetMinColorTempKelvin()
    {
        if (MinColorTempKelvin == null)
        {
            // Log usage
            return ColorUtil.ColorTemperatureMiredToKelvin(MaxMireds);
        }
        return MinColorTempKelvin.Value;
    }

    public int GetMaxColorTempKelvin()
    {
        if (MaxColorTempKelvin == null)
        {
            // Log usage
            return ColorUtil.ColorTemperatureMiredToKelvin(MinMireds);
        }
        return MaxColorTempKelvin.Value;
    }

    public Dictionary<string, object?> GetCapabilityAttributes()
    {
        var data = new Dictionary<string, object?>();
        var supportedFeatures = GetSupportedFeaturesCompat();
        var supportedColorModes = GetInternalSupportedColorModes();

        if (supportedColorModes.Contains("color_temp"))
        {
            var minColorTempKelvin = GetMinColorTempKelvin();
            var maxColorTempKelvin = GetMaxColorTempKelvin();
            data["min_color_temp_kelvin"] = minColorTempKelvin;
            data["max_color_temp_kelvin"] = maxColorTempKelvin;
            if (maxColorTempKelvin == 0)
            {
                data["min_mireds"] = null;
            }
            else
            {
                data["min_mireds"] = ColorUtil.ColorTemperatureKelvinToMired(maxColorTempKelvin);
            }
            if (minColorTempKelvin == 0)
            {
                data["max_mireds"] = null;
            }
            else
            {
                data["max_mireds"] = ColorUtil.ColorTemperatureKelvinToMired(minColorTempKelvin);
            }
        }
        if (supportedFeatures.HasFlag(LightEntityFeature.Effect))
        {
            data["effect_list"] = EffectList;
        }

        data["supported_color_modes"] = new List<string>(supportedColorModes);

        return data;
    }

    private Dictionary<string, Tuple<float, float>> InternalConvertColor(string colorMode)
    {
        var data = new Dictionary<string, Tuple<float, float>>();
        if (colorMode == "hs" && HsColor != null)
        {
            data["hs_color"] = Tuple.Create((float)Math.Round(HsColor.Item1, 3), (float)Math.Round(HsColor.Item2, 3));
            data["rgb_color"] = ColorUtil.ColorHsToRgb(HsColor.Item1, HsColor.Item2);
            data["xy_color"] = ColorUtil.ColorHsToXy(HsColor.Item1, HsColor.Item2);
        }
        else if (colorMode == "xy" && XyColor != null)
        {
            data["hs_color"] = ColorUtil.ColorXyToHs(XyColor.Item1, XyColor.Item2);
            data["rgb_color"] = ColorUtil.ColorXyToRgb(XyColor.Item1, XyColor.Item2);
            data["xy_color"] = Tuple.Create((float)Math.Round(XyColor.Item1, 6), (float)Math.Round(XyColor.Item2, 6));
        }
        else if (colorMode == "rgb" && RgbColor != null)
        {
            data["hs_color"] = ColorUtil.ColorRgbToHs(RgbColor.Item1, RgbColor.Item2, RgbColor.Item3);
            data["rgb_color"] = Tuple.Create(RgbColor.Item1, RgbColor.Item2, RgbColor.Item3);
            data["xy_color"] = ColorUtil.ColorRgbToXy(RgbColor.Item1, RgbColor.Item2, RgbColor.Item3);
        }
        else if (colorMode == "rgbw" && RgbwColor != null)
        {
            var rgbColor = ColorUtil.ColorRgbwToRgb(RgbwColor.Item1, RgbwColor.Item2, RgbwColor.Item3, RgbwColor.Item4);
            data["hs_color"] = ColorUtil.ColorRgbToHs(rgbColor.Item1, rgbColor.Item2, rgbColor.Item3);
            data["rgb_color"] = Tuple.Create(rgbColor.Item1, rgbColor.Item2, rgbColor.Item3);
            data["rgbw_color"] = Tuple.Create(RgbwColor.Item1, RgbwColor.Item2, RgbwColor.Item3, RgbwColor.Item4);
            data["xy_color"] = ColorUtil.ColorRgbToXy(rgbColor.Item1, rgbColor.Item2, rgbColor.Item3);
        }
        else if (colorMode == "rgbww" && RgbwwColor != null)
        {
            var rgbColor = ColorUtil.ColorRgbwwToRgb(RgbwwColor.Item1, RgbwwColor.Item2, RgbwwColor.Item3, RgbwwColor.Item4, RgbwwColor.Item5, MinColorTempKelvin.Value, MaxColorTempKelvin.Value);
            data["hs_color"] = ColorUtil.ColorRgbToHs(rgbColor.Item1, rgbColor.Item2, rgbColor.Item3);
            data["rgb_color"] = Tuple.Create(rgbColor.Item1, rgbColor.Item2, rgbColor.Item3);
            data["rgbww_color"] = Tuple.Create(RgbwwColor.Item1, RgbwwColor.Item2, RgbwwColor.Item3, RgbwwColor.Item4, RgbwwColor.Item5);
            data["xy_color"] = ColorUtil.ColorRgbToXy(rgbColor.Item1, rgbColor.Item2, rgbColor.Item3);
        }
        else if (colorMode == "color_temp" && ColorTempKelvin != null)
        {
            var hsColor = ColorUtil.ColorTemperatureToHs(ColorTempKelvin.Value);
            data["hs_color"] = Tuple.Create((float)Math.Round(hsColor.Item1, 3), (float)Math.Round(hsColor.Item2, 3));
            data["rgb_color"] = ColorUtil.ColorHsToRgb(hsColor.Item1, hsColor.Item2);
            data["xy_color"] = ColorUtil.ColorHsToXy(hsColor.Item1, hsColor.Item2);
        }
        return data;
    }

    private void ValidateColorMode(string? colorMode, HashSet<string> supportedColorModes, string? effect)
    {
        if (colorMode == null || colorMode == "unknown")
        {
            return;
        }

        if (string.IsNullOrEmpty(effect) || effect == "off")
        {
            if (supportedColorModes.Contains(colorMode))
            {
                return;
            }
            if (!_colorModeReported)
            {
                _colorModeReported = true;
                // Log warning
            }
            return;
        }

        var effectColorModes = new HashSet<string>(supportedColorModes) { "onoff" };
        if (BrightnessSupported(effectColorModes))
        {
            effectColorModes.Add("brightness");
        }

        if (effectColorModes.Contains(colorMode))
        {
            return;
        }

        if (!_colorModeReported)
        {
            _colorModeReported = true;
            // Log warning
        }
    }

    private void ValidateSupportedColorModes(HashSet<string> supportedColorModes)
    {
        if (_colorModeReported)
        {
            return;
        }

        try
        {
            ValidSupportedColorModes(supportedColorModes);
        }
        catch (Exception)
        {
            if (!_colorModeReported)
            {
                _colorModeReported = true;
                // Log warning
            }
        }
    }

    public Dictionary<string, object?> GetStateAttributes()
    {
        var data = new Dictionary<string, object?>();
        var supportedFeatures = GetSupportedFeaturesCompat();
        var supportedColorModes = SupportedColorModes ?? GetInternalSupportedColorModes();
        var supportedFeaturesValue = supportedFeatures.Value;
        var isOn = IsOn;
        var colorMode = isOn ? GetInternalColorMode() : null;

        if (supportedFeatures.HasFlag(LightEntityFeature.Effect))
        {
            data["effect"] = isOn ? Effect : null;
        }

        ValidateColorMode(colorMode, supportedColorModes, isOn ? Effect : null);

        data["color_mode"] = colorMode;

        if (BrightnessSupported(supportedColorModes))
        {
            data["brightness"] = ColorMode == "brightness" ? Brightness : null;
        }
        else if (supportedFeaturesValue.HasFlag(LightEntityFeature.Brightness))
        {
            data["brightness"] = isOn ? Brightness : null;
        }

        if (ColorTempSupported(supportedColorModes))
        {
            if (ColorMode == "color_temp")
            {
                data["color_temp_kelvin"] = GetColorTempKelvin();
                data["color_temp"] = GetColorTempKelvin() != null ? (int?)ColorUtil.ColorTemperatureKelvinToMired(GetColorTempKelvin().Value) : null;
            }
            else
            {
                data["color_temp_kelvin"] = null;
                data["color_temp"] = null;
            }
        }
        else if (supportedFeaturesValue.HasFlag(LightEntityFeature.ColorTemp))
        {
            data["color_temp_kelvin"] = isOn ? GetColorTempKelvin() : null;
            data["color_temp"] = isOn ? (int?)ColorUtil.ColorTemperatureKelvinToMired(GetColorTempKelvin().Value) : null;
        }

        if (ColorSupported(supportedColorModes) || ColorTempSupported(supportedColorModes))
        {
            data["hs_color"] = null;
            data["rgb_color"] = null;
            data["xy_color"] = null;
            if (supportedColorModes.Contains("rgbw"))
            {
                data["rgbw_color"] = null;
            }
            if (supportedColorModes.Contains("rgbww"))
            {
                data["rgbww_color"] = null;
            }
            if (colorMode != null)
            {
                var colorData = InternalConvertColor(colorMode);
                foreach (var item in colorData)
                {
                    data[item.Key] = item.Value;
                }
            }
        }

        return data;
    }

    private HashSet<string> GetInternalSupportedColorModes()
    {
        if (SupportedColorModes != null)
        {
            ValidateSupportedColorModes(SupportedColorModes);
            return SupportedColorModes;
        }

        if (!_colorModeReported)
        {
            _colorModeReported = true;
            // Log warning
        }

        var supportedFeatures = GetSupportedFeaturesCompat();
        var supportedFeaturesValue = supportedFeatures.Value;
        var supportedColorModes = new HashSet<string>();

        if (supportedFeaturesValue.HasFlag(LightEntityFeature.ColorTemp))
        {
            supportedColorModes.Add("color_temp");
        }
        if (supportedFeaturesValue.HasFlag(LightEntityFeature.Color))
        {
            supportedColorModes.Add("hs");
        }
        if (!supportedColorModes.Contains("brightness") && supportedFeaturesValue.HasFlag(LightEntityFeature.Brightness))
        {
            supportedColorModes.Add("brightness");
        }
        if (!supportedColorModes.Contains("onoff"))
        {
            supportedColorModes.Add("onoff");
        }

        return supportedColorModes;
    }

    public HashSet<string>? SupportedColorModes { get; set; }

    public LightEntityFeature SupportedFeatures { get; set; } = new LightEntityFeature(0);

    private HashSet<string> GetInternalSupportedColorModes()
    {
        if (SupportedColorModes != null)
        {
            ValidateSupportedColorModes(SupportedColorModes);
            return SupportedColorModes;
        }

        if (!_colorModeReported)
        {
            _colorModeReported = true;
            // Log warning
        }

        var supportedFeatures = GetSupportedFeaturesCompat();
        var supportedFeaturesValue = supportedFeatures.Value;
        var supportedColorModes = new HashSet<string>();

        if (supportedFeaturesValue.HasFlag(LightEntityFeature.ColorTemp))
        {
            supportedColorModes.Add("color_temp");
        }
        if (supportedFeaturesValue.HasFlag(LightEntityFeature.Color))
        {
            supportedColorModes.Add("hs");
        }
        if (!supportedColorModes.Contains("brightness") && supportedFeaturesValue.HasFlag(LightEntityFeature.Brightness))
        {
            supportedColorModes.Add("brightness");
        }
        if (!supportedColorModes.Contains("onoff"))
        {
            supportedColorModes.Add("onoff");
        }

        return supportedColorModes;
    }
}