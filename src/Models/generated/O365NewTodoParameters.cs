//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.5371039-08:00
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
public partial record O365NewTodoParameters
{
    ///<summary>The subject of the todo eg: Pick up the mail</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; init; }

    ///<summary>Description of the todo eg: Walk to the post box and collect the mail</summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    ///<summary>When the todo is due by eg: &quot;2025-01-01&quot;</summary>
    [JsonPropertyName("due")]
    public DateOnly? Due { get; init; }

    ///<summary>When a reminder is needed eg: 2025-01-01T12:00:00+0000</summary>
    [JsonPropertyName("reminder")]
    public DateTime? Reminder { get; init; }
}