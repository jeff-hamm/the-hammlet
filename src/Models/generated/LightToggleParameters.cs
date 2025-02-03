//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.1196618-08:00
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
public partial record LightToggleParameters
{
    ///<summary>Duration it takes to get to next state.</summary>
    [JsonPropertyName("transition")]
    public double? Transition { get; init; }

    ///<summary>The color in RGB format. A list of three integers between 0 and 255 representing the values of red, green, and blue. eg: [255, 100, 100]</summary>
    [JsonPropertyName("rgb_color")]
    public IReadOnlyCollection<int>? RgbColor { get; init; }

    ///<summary>Color temperature in Kelvin.</summary>
    [JsonPropertyName("kelvin")]
    public object? Kelvin { get; init; }

    ///<summary>Number indicating the percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness, and 100 is the maximum brightness.</summary>
    [JsonPropertyName("brightness_pct")]
    public double? BrightnessPct { get; init; }

    ///<summary>Light effect.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; init; }

    ///<summary> eg: [255, 100, 100, 50]</summary>
    [JsonPropertyName("rgbw_color")]
    public object? RgbwColor { get; init; }

    ///<summary> eg: [255, 100, 100, 50, 70]</summary>
    [JsonPropertyName("rgbww_color")]
    public object? RgbwwColor { get; init; }

    [JsonPropertyName("color_name")]
    public object? ColorName { get; init; }

    ///<summary> eg: [300, 70]</summary>
    [JsonPropertyName("hs_color")]
    public object? HsColor { get; init; }

    ///<summary> eg: [0.52, 0.43]</summary>
    [JsonPropertyName("xy_color")]
    public object? XyColor { get; init; }

    [JsonPropertyName("color_temp")]
    public object? ColorTemp { get; init; }

    [JsonPropertyName("brightness")]
    public double? Brightness { get; init; }

    [JsonPropertyName("white")]
    public object? White { get; init; }

    ///<summary> eg: relax</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; init; }

    [JsonPropertyName("flash")]
    public object? Flash { get; init; }
}