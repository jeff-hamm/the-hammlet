//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T15:53:27.6561017-08:00
//
// *** Make sure the version of the codegen tool and your nugets NetDaemon.* have the same version.***
// You can use following command to keep it up to date with the latest version:
//   dotnet tool update NetDaemon.HassModel.CodeGen
//
// To update this file with latest entities run this command in your project directory:
//   dotnet tool run nd-codegen
//
// In the template projects we provided a convenience powershell script that will update
// the codegen and nugets to latest versions update_all_dependencies.ps1.
//
// For more information: https://netdaemon.xyz/docs/user/hass_model/hass_model_codegen
// For more information about NetDaemon: https://netdaemon.xyz/
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using System.Text.Json.Serialization;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;
using NetDaemon.HassModel.Entities.Core;

namespace Hammlet.NetDaemon.Models;
public partial record LightAttributes
{
    [JsonPropertyName("supported_color_modes")]
    public System.Collections.Generic.IReadOnlyList<Hammlet.Models.Enums.ColorMode>? SupportedColorModes { get; init; }

    [JsonPropertyName("color_mode")]
    public Hammlet.Models.Enums.ColorMode? ColorMode { get; init; }

    [JsonPropertyName("supported_features")]
    public double? SupportedFeatures { get; init; }

    [JsonPropertyName("min_color_temp_kelvin")]
    public double? MinColorTempKelvin { get; init; }

    [JsonPropertyName("max_color_temp_kelvin")]
    public double? MaxColorTempKelvin { get; init; }

    [JsonPropertyName("min_mireds")]
    public double? MinMireds { get; init; }

    [JsonPropertyName("max_mireds")]
    public double? MaxMireds { get; init; }

    [JsonPropertyName("brightness")]
    public double? Brightness { get; init; }

    [JsonPropertyName("color_temp_kelvin")]
    public double? ColorTempKelvin { get; init; }

    [JsonPropertyName("color_temp")]
    public double? ColorTemp { get; init; }

    [JsonPropertyName("hs_color")]
    public IReadOnlyList<IReadOnlyList<double>>? HsColor { get; init; }

    [JsonPropertyName("rgb_color")]
    public IReadOnlyList<IReadOnlyList<double>>? RgbColor { get; init; }

    [JsonPropertyName("xy_color")]
    public IReadOnlyList<IReadOnlyList<double>>? XyColor { get; init; }

    [JsonPropertyName("entity_id")]
    public IReadOnlyList<LightEntityId>? EntityId { get; init; }

    [JsonPropertyName("effect_list")]
    public IReadOnlyList<LightEffectList>? EffectList { get; init; }

    [JsonPropertyName("color")]
    public System.Object? Color { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("effect")]
    public object? Effect { get; init; }

    [JsonPropertyName("raw_state")]
    public bool? RawState { get; init; }

    [JsonPropertyName("restored")]
    public bool? Restored { get; init; }
}