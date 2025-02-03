//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T15:53:28.2103994-08:00
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
public partial record ZhaToolkitOtaNotifyParameters
{
    ///<summary>Entity name, device name, or IEEE address of the node to execute command eg: entity.name_of_zigbee_device</summary>
    [JsonPropertyName("ieee")]
    public string? Ieee { get; init; }

    ///<summary>When True, download FW from KKoenk&apos;s list that possibly matches devices.</summary>
    [JsonPropertyName("download")]
    public bool? Download { get; init; }

    ///<summary>Path to write ota image(s) to (defaults to zha:zigpy_config:ota:otau_directory value or /config/zigpy_ota)</summary>
    [JsonPropertyName("path")]
    public string? Path { get; init; }

    ///<summary>Number of times the zigbee packet should be attempted</summary>
    [JsonPropertyName("tries")]
    public double? Tries { get; init; }

    ///<summary>Event name in case of success eg: ota_notify_success</summary>
    [JsonPropertyName("event_success")]
    public string? EventSuccess { get; init; }

    ///<summary>Event name in case of failure eg: ota_notify_fail</summary>
    [JsonPropertyName("event_fail")]
    public string? EventFail { get; init; }

    ///<summary>Event name when the images were updated and the device notified (either success or failure). eg: ota_notify_done</summary>
    [JsonPropertyName("event_done")]
    public string? EventDone { get; init; }

    ///<summary>Throw exception when success==False, useful to stop scripts, automations</summary>
    [JsonPropertyName("fail_exception")]
    public bool? FailException { get; init; }

    ///<summary>Wait for/expect a reply (not used yet)</summary>
    [JsonPropertyName("expect_reply")]
    public bool? ExpectReply { get; init; }
}