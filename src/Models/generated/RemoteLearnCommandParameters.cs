//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.5639455-08:00
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
public partial record RemoteLearnCommandParameters
{
    ///<summary>Device ID to learn command from. eg: television</summary>
    [JsonPropertyName("device")]
    public string? Device { get; init; }

    ///<summary>A single command or a list of commands to learn. eg: Turn on</summary>
    [JsonPropertyName("command")]
    public object? Command { get; init; }

    ///<summary>The type of command to be learned.</summary>
    [JsonPropertyName("command_type")]
    public object? CommandType { get; init; }

    ///<summary>If code must be stored as an alternative. This is useful for discrete codes. Discrete codes are used for toggles that only perform one function. For example, a code to only turn a device on. If it is on already, sending the code won&apos;t change the state.</summary>
    [JsonPropertyName("alternative")]
    public bool? Alternative { get; init; }

    ///<summary>Timeout for the command to be learned.</summary>
    [JsonPropertyName("timeout")]
    public long? Timeout { get; init; }
}