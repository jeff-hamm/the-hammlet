//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.4776701-08:00
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
public static class AutomationEntityExtensionMethods
{
    ///<summary>Toggles (enable / disable) an automation.</summary>
    public static void Toggle(this IAutomationEntityCore target, object? data = null)
    {
        target.CallService("toggle", data);
    }

    ///<summary>Toggles (enable / disable) an automation.</summary>
    public static void Toggle(this IEnumerable<IAutomationEntityCore> target, object? data = null)
    {
        target.CallService("toggle", data);
    }

    ///<summary>Triggers the actions of an automation.</summary>
    public static void Trigger(this IAutomationEntityCore target, AutomationTriggerParameters data)
    {
        target.CallService("trigger", data);
    }

    ///<summary>Triggers the actions of an automation.</summary>
    public static void Trigger(this IEnumerable<IAutomationEntityCore> target, AutomationTriggerParameters data)
    {
        target.CallService("trigger", data);
    }

    ///<summary>Triggers the actions of an automation.</summary>
    ///<param name="target">The IAutomationEntityCore to call this service for</param>
    ///<param name="skipCondition">Defines whether or not the conditions will be skipped.</param>
    public static void Trigger(this IAutomationEntityCore target, bool? skipCondition = null)
    {
        target.CallService("trigger", new AutomationTriggerParameters { SkipCondition = skipCondition });
    }

    ///<summary>Triggers the actions of an automation.</summary>
    ///<param name="target">The IEnumerable&lt;IAutomationEntityCore&gt; to call this service for</param>
    ///<param name="skipCondition">Defines whether or not the conditions will be skipped.</param>
    public static void Trigger(this IEnumerable<IAutomationEntityCore> target, bool? skipCondition = null)
    {
        target.CallService("trigger", new AutomationTriggerParameters { SkipCondition = skipCondition });
    }

    ///<summary>Disables an automation.</summary>
    public static void TurnOff(this IAutomationEntityCore target, AutomationTurnOffParameters data)
    {
        target.CallService("turn_off", data);
    }

    ///<summary>Disables an automation.</summary>
    public static void TurnOff(this IEnumerable<IAutomationEntityCore> target, AutomationTurnOffParameters data)
    {
        target.CallService("turn_off", data);
    }

    ///<summary>Disables an automation.</summary>
    ///<param name="target">The IAutomationEntityCore to call this service for</param>
    ///<param name="stopActions">Stops currently running actions.</param>
    public static void TurnOff(this IAutomationEntityCore target, bool? stopActions = null)
    {
        target.CallService("turn_off", new AutomationTurnOffParameters { StopActions = stopActions });
    }

    ///<summary>Disables an automation.</summary>
    ///<param name="target">The IEnumerable&lt;IAutomationEntityCore&gt; to call this service for</param>
    ///<param name="stopActions">Stops currently running actions.</param>
    public static void TurnOff(this IEnumerable<IAutomationEntityCore> target, bool? stopActions = null)
    {
        target.CallService("turn_off", new AutomationTurnOffParameters { StopActions = stopActions });
    }

    ///<summary>Enables an automation.</summary>
    public static void TurnOn(this IAutomationEntityCore target, object? data = null)
    {
        target.CallService("turn_on", data);
    }

    ///<summary>Enables an automation.</summary>
    public static void TurnOn(this IEnumerable<IAutomationEntityCore> target, object? data = null)
    {
        target.CallService("turn_on", data);
    }
}