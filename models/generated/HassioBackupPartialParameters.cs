//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v24.52.0.0
//   At: 2025-01-16T04:15:56.1561839-08:00
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
public partial record HassioBackupPartialParameters
{
    ///<summary>Includes Home Assistant settings in the backup.</summary>
    [JsonPropertyName("homeassistant")]
    public bool? Homeassistant { get; init; }

    ///<summary>Exclude the Home Assistant database file from backup</summary>
    [JsonPropertyName("homeassistant_exclude_database")]
    public bool? HomeassistantExcludeDatabase { get; init; }

    ///<summary>List of add-ons to include in the backup. Use the name slug of each add-on. eg: [&quot;core_ssh&quot;,&quot;core_samba&quot;,&quot;core_mosquitto&quot;]</summary>
    [JsonPropertyName("addons")]
    public object? Addons { get; init; }

    ///<summary>List of directories to include in the backup. eg: [&quot;homeassistant&quot;,&quot;share&quot;]</summary>
    [JsonPropertyName("folders")]
    public object? Folders { get; init; }

    ///<summary>Optional (default = current date and time). eg: Partial backup 1</summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    ///<summary>Password to protect the backup with. eg: password</summary>
    [JsonPropertyName("password")]
    public string? Password { get; init; }

    ///<summary>Compresses the backup files.</summary>
    [JsonPropertyName("compressed")]
    public bool? Compressed { get; init; }

    ///<summary>Name of a backup network storage to host backups. eg: my_backup_mount</summary>
    [JsonPropertyName("location")]
    public object? Location { get; init; }
}