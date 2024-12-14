//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v24.50.0.0
//   At: 2024-12-14T14:51:18.7854221-08:00
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
public partial record MqttPublishParameters
{
    ///<summary>Topic to publish to. eg: /homeassistant/hello</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; init; }

    ///<summary>The payload to publish. eg: The temperature is {{ states(&apos;sensor.temperature&apos;) }}</summary>
    [JsonPropertyName("payload")]
    public object? Payload { get; init; }

    ///<summary>When `payload` is a Python bytes literal, evaluate the bytes literal and publish the raw data.</summary>
    [JsonPropertyName("evaluate_payload")]
    public bool? EvaluatePayload { get; init; }

    ///<summary>Quality of Service to use. 0: At most once. 1: At least once. 2: Exactly once.</summary>
    [JsonPropertyName("qos")]
    public object? Qos { get; init; }

    ///<summary>If the message should have the retain flag set. If set, the broker stores the most recent message on a topic.</summary>
    [JsonPropertyName("retain")]
    public bool? Retain { get; init; }
}