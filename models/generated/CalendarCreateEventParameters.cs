//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v24.52.0.0
//   At: 2025-01-16T04:15:56.0822689-08:00
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
public partial record CalendarCreateEventParameters
{
    ///<summary>Defines the short summary or subject for the event. eg: Department Party</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; init; }

    ///<summary>A more complete description of the event than the one provided by the summary. eg: Meeting to provide technical review for &apos;Phoenix&apos; design.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    ///<summary>The date and time the event should start. eg: 2022-03-22 20:00:00</summary>
    [JsonPropertyName("start_date_time")]
    public DateTime? StartDateTime { get; init; }

    ///<summary>The date and time the event should end. eg: 2022-03-22 22:00:00</summary>
    [JsonPropertyName("end_date_time")]
    public DateTime? EndDateTime { get; init; }

    ///<summary>The date the all-day event should start. eg: 2022-03-22</summary>
    [JsonPropertyName("start_date")]
    public DateOnly? StartDate { get; init; }

    ///<summary>The date the all-day event should end (exclusive). eg: 2022-03-23</summary>
    [JsonPropertyName("end_date")]
    public DateOnly? EndDate { get; init; }

    ///<summary>Days or weeks that you want to create the event in. eg: {&quot;days&quot;: 2} or {&quot;weeks&quot;: 2}</summary>
    [JsonPropertyName("in")]
    public object? In { get; init; }

    ///<summary>The location of the event. eg: Conference Room - F123, Bldg. 002</summary>
    [JsonPropertyName("location")]
    public string? Location { get; init; }
}