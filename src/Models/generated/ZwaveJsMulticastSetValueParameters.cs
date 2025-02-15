//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.7910049-08:00
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
public partial record ZwaveJsMulticastSetValueParameters
{
    ///<summary>The area(s) to target for this action. If an area is specified, all Z-Wave devices and entities in that area will be targeted for this action. eg: living_room</summary>
    [JsonPropertyName("area_id")]
    public IEnumerable<string>? AreaId { get; init; }

    ///<summary>The device(s) to target for this action. eg: 8f4219cfa57e23f6f669c4616c2205e2</summary>
    [JsonPropertyName("device_id")]
    public IEnumerable<string>? DeviceId { get; init; }

    ///<summary>The entity ID(s) to target for this action. eg: sensor.living_room_temperature</summary>
    [JsonPropertyName("entity_id")]
    public IEnumerable<string>? EntityId { get; init; }

    ///<summary>Whether command should be broadcast to all devices on the network. eg: True</summary>
    [JsonPropertyName("broadcast")]
    public bool? Broadcast { get; init; }

    ///<summary>The ID of the command class for the value. eg: 117</summary>
    [JsonPropertyName("command_class")]
    public string? CommandClass { get; init; }

    ///<summary>The endpoint for the value. eg: 1</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; init; }

    ///<summary>The ID of the property for the value. eg: currentValue</summary>
    [JsonPropertyName("property")]
    public string? Property { get; init; }

    ///<summary>The ID of the property key for the value. eg: 1</summary>
    [JsonPropertyName("property_key")]
    public string? PropertyKey { get; init; }

    ///<summary>Set value options map. Refer to the Z-Wave documentation for more information on what options can be set.</summary>
    [JsonPropertyName("options")]
    public object? Options { get; init; }

    ///<summary>The new value to set. eg: ffbb99</summary>
    [JsonPropertyName("value")]
    public object? Value { get; init; }
}