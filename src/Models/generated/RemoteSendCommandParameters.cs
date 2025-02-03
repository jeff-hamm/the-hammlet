//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.2259362-08:00
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
public partial record RemoteSendCommandParameters
{
    ///<summary>Device ID to send command to. eg: 32756745</summary>
    [JsonPropertyName("device")]
    public string? Device { get; init; }

    ///<summary>A single command or a list of commands to send. eg: Play</summary>
    [JsonPropertyName("command")]
    public object? Command { get; init; }

    ///<summary>The number of times you want to repeat the commands.</summary>
    [JsonPropertyName("num_repeats")]
    public double? NumRepeats { get; init; }

    ///<summary>The time you want to wait in between repeated commands.</summary>
    [JsonPropertyName("delay_secs")]
    public double? DelaySecs { get; init; }

    ///<summary>The time you want to have it held before the release is send.</summary>
    [JsonPropertyName("hold_secs")]
    public double? HoldSecs { get; init; }
}