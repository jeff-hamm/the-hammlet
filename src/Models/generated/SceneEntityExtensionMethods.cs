//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.8634483-08:00
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
public static class SceneEntityExtensionMethods
{
    ///<summary>Deletes a dynamically created scene.</summary>
    public static void Delete(this ISceneEntityCore target, object? data = null)
    {
        target.CallService("delete", data);
    }

    ///<summary>Deletes a dynamically created scene.</summary>
    public static void Delete(this IEnumerable<ISceneEntityCore> target, object? data = null)
    {
        target.CallService("delete", data);
    }

    ///<summary>Activates a scene.</summary>
    public static void TurnOn(this ISceneEntityCore target, SceneTurnOnParameters data)
    {
        target.CallService("turn_on", data);
    }

    ///<summary>Activates a scene.</summary>
    public static void TurnOn(this IEnumerable<ISceneEntityCore> target, SceneTurnOnParameters data)
    {
        target.CallService("turn_on", data);
    }

    ///<summary>Activates a scene.</summary>
    ///<param name="target">The ISceneEntityCore to call this service for</param>
    ///<param name="transition">Time it takes the devices to transition into the states defined in the scene.</param>
    public static void TurnOn(this ISceneEntityCore target, double? transition = null)
    {
        target.CallService("turn_on", new SceneTurnOnParameters { Transition = transition });
    }

    ///<summary>Activates a scene.</summary>
    ///<param name="target">The IEnumerable&lt;ISceneEntityCore&gt; to call this service for</param>
    ///<param name="transition">Time it takes the devices to transition into the states defined in the scene.</param>
    public static void TurnOn(this IEnumerable<ISceneEntityCore> target, double? transition = null)
    {
        target.CallService("turn_on", new SceneTurnOnParameters { Transition = transition });
    }
}