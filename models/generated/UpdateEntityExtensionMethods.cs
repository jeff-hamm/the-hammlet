//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v24.52.0.0
//   At: 2025-01-16T04:15:56.7417316-08:00
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
public static class UpdateEntityExtensionMethods
{
    ///<summary>Removes the skipped version marker from an update.</summary>
    public static void ClearSkipped(this IUpdateEntityCore target, object? data = null)
    {
        target.CallService("clear_skipped", data);
    }

    ///<summary>Removes the skipped version marker from an update.</summary>
    public static void ClearSkipped(this IEnumerable<IUpdateEntityCore> target, object? data = null)
    {
        target.CallService("clear_skipped", data);
    }

    ///<summary>Installs an update for a device or service.</summary>
    public static void Install(this IUpdateEntityCore target, UpdateInstallParameters data)
    {
        target.CallService("install", data);
    }

    ///<summary>Installs an update for a device or service.</summary>
    public static void Install(this IEnumerable<IUpdateEntityCore> target, UpdateInstallParameters data)
    {
        target.CallService("install", data);
    }

    ///<summary>Installs an update for a device or service.</summary>
    ///<param name="target">The IUpdateEntityCore to call this service for</param>
    ///<param name="version">The version to install. If omitted, the latest version will be installed. eg: 1.0.0</param>
    ///<param name="backup">If supported by the integration, this creates a backup before starting the update.</param>
    public static void Install(this IUpdateEntityCore target, string? version = null, bool? backup = null)
    {
        target.CallService("install", new UpdateInstallParameters { Version = version, Backup = backup });
    }

    ///<summary>Installs an update for a device or service.</summary>
    ///<param name="target">The IEnumerable&lt;IUpdateEntityCore&gt; to call this service for</param>
    ///<param name="version">The version to install. If omitted, the latest version will be installed. eg: 1.0.0</param>
    ///<param name="backup">If supported by the integration, this creates a backup before starting the update.</param>
    public static void Install(this IEnumerable<IUpdateEntityCore> target, string? version = null, bool? backup = null)
    {
        target.CallService("install", new UpdateInstallParameters { Version = version, Backup = backup });
    }

    ///<summary>Marks currently available update as skipped.</summary>
    public static void Skip(this IUpdateEntityCore target, object? data = null)
    {
        target.CallService("skip", data);
    }

    ///<summary>Marks currently available update as skipped.</summary>
    public static void Skip(this IEnumerable<IUpdateEntityCore> target, object? data = null)
    {
        target.CallService("skip", data);
    }
}