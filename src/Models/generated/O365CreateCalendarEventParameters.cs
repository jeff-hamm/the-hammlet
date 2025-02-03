//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T15:53:28.0100997-08:00
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
public partial record O365CreateCalendarEventParameters
{
    ///<summary>The subject of the created event eg: Clean up the garage</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; init; }

    ///<summary>The start time of the event eg: 2025-03-22 20:00:00</summary>
    [JsonPropertyName("start")]
    public DateTime? Start { get; init; }

    ///<summary>The end time of the event eg: 2025-03-22 20:30:00</summary>
    [JsonPropertyName("end")]
    public DateTime? End { get; init; }

    ///<summary>The body text for the event (optional) eg: Remember to also clean out the gutters</summary>
    [JsonPropertyName("body")]
    public string? Body { get; init; }

    ///<summary>The location for the event (optional) eg: 1600 Pennsylvania Ave Nw, Washington, DC 20500</summary>
    [JsonPropertyName("location")]
    public string? Location { get; init; }

    ///<summary>list of categories for the event (optional)</summary>
    [JsonPropertyName("categories")]
    public string? Categories { get; init; }

    ///<summary>The sensitivity for the event (optional) [Normal, Personal, Private, Confidential] eg: normal</summary>
    [JsonPropertyName("sensitivity")]
    public object? Sensitivity { get; init; }

    ///<summary>Show event as (optional) [Free, Tentative, Busy, Oof, WorkingElsewhere, Unknown] eg: busy</summary>
    [JsonPropertyName("show_as")]
    public object? ShowAs { get; init; }

    ///<summary>Set whether event is all day (optional) eg: False</summary>
    [JsonPropertyName("is_all_day")]
    public bool? IsAllDay { get; init; }

    ///<summary>list of attendees formatted as email: example@example.com type: Required, Optional, or Resource (optional)</summary>
    [JsonPropertyName("attendees")]
    public object? Attendees { get; init; }
}