//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.7245689-08:00
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
public partial record ZhaToolkitAttrWriteParameters
{
    ///<summary>Entity name, device name, or IEEE address of the node to execute command eg: 00:0d:6f:00:05:7d:2d:34</summary>
    [JsonPropertyName("ieee")]
    public string? Ieee { get; init; }

    ///<summary>Manufacturer id (0 = No manufacturer id, empty=possibly automatic)</summary>
    [JsonPropertyName("manf")]
    public double? Manf { get; init; }

    ///<summary>target endpoint</summary>
    [JsonPropertyName("endpoint")]
    public double? Endpoint { get; init; }

    ///<summary>target cluster</summary>
    [JsonPropertyName("cluster")]
    public double? Cluster { get; init; }

    ///<summary>target attribute id (or name, accepted in most cases)</summary>
    [JsonPropertyName("attribute")]
    public double? Attribute { get; init; }

    ///<summary>Attribute type (to write, ...)</summary>
    [JsonPropertyName("attr_type")]
    public double? AttrType { get; init; }

    ///<summary>Attribute value to write</summary>
    [JsonPropertyName("attr_val")]
    public string? AttrVal { get; init; }

    ///<summary>Use zigpy attribute cache to get the value of an attribute. (Does not send a zigbee packet to read the attribute) eg: True</summary>
    [JsonPropertyName("use_cache")]
    public bool? UseCache { get; init; }

    ///<summary>Number of times the zigbee packet should be attempted</summary>
    [JsonPropertyName("tries")]
    public double? Tries { get; init; }

    ///<summary>When defined, name of state to write the read attribute value to eg: sensor.example</summary>
    [JsonPropertyName("state_id")]
    public string? StateId { get; init; }

    ///<summary>When defined, attribute in state_id to write the read attribute value to.  Write to state value when missing (and state_id is defined) eg: other_attr</summary>
    [JsonPropertyName("state_attr")]
    public string? StateAttr { get; init; }

    ///<summary>Event name in case of success eg: my_read_success_trigger_event</summary>
    [JsonPropertyName("event_success")]
    public string? EventSuccess { get; init; }

    ///<summary>Event name in case of failure eg: my_read_fail_trigger_event</summary>
    [JsonPropertyName("event_fail")]
    public string? EventFail { get; init; }

    ///<summary>Event name when the service call did all its work (either success or failure).  Has event data with relevant attributes. eg: my_read_done_trigger_event</summary>
    [JsonPropertyName("event_done")]
    public string? EventDone { get; init; }

    ///<summary>Throw exception when success==False, useful to stop scripts, automations</summary>
    [JsonPropertyName("fail_exception")]
    public bool? FailException { get; init; }

    ///<summary>Allow state creation (given by state_id) if it does not exist</summary>
    [JsonPropertyName("allow_create")]
    public bool? AllowCreate { get; init; }

    ///<summary>Read attribute before writing it (used with attr_write).  When the read value matches the value to write, no write is done. Defaults to True.</summary>
    [JsonPropertyName("read_before_write")]
    public bool? ReadBeforeWrite { get; init; }

    ///<summary>Read attribute after writing.  Can be used to ensure the values match.  Defaults to True</summary>
    [JsonPropertyName("read_after_write")]
    public bool? ReadAfterWrite { get; init; }

    ///<summary>Force writing the attribute even if the read attribute already matches.  Defaults to False</summary>
    [JsonPropertyName("write_if_equal")]
    public bool? WriteIfEqual { get; init; }

    ///<summary>Wait for/expect a reply (not used yet)</summary>
    [JsonPropertyName("expect_reply")]
    public bool? ExpectReply { get; init; }

    ///<summary>Filename of CSV to write read data to.  Written to &apos;csv&apos; directory eg: ../web/mycsv.csv</summary>
    [JsonPropertyName("csvout")]
    public string? Csvout { get; init; }

    ///<summary>Label to use for read value (in CSV file) eg: SecretAttributeName</summary>
    [JsonPropertyName("csvlabel")]
    public string? Csvlabel { get; init; }
}