//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-14T18:42:13.2123782-08:00
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

namespace HomeAssistantGenerated;
public partial record SirenTurnOnParameters
{
    ///<summary>The tone to emit. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</summary>
    [JsonPropertyName("tone")]
    public string? Tone { get; init; }

    ///<summary>The volume. 0 is inaudible, 1 is the maximum volume. Must be supported by the integration. eg: 0.5</summary>
    [JsonPropertyName("volume_level")]
    public double? VolumeLevel { get; init; }

    ///<summary>Number of seconds the sound is played. Must be supported by the integration. eg: 15</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; init; }
}