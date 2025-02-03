//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T15:53:27.8301493-08:00
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
public partial class AutomationServices
{
    private readonly IHaContext _haContext;
    public AutomationServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Reloads the automation configuration.</summary>
    public void Reload(object? data = null)
    {
        _haContext.CallService("automation", "reload", null, data);
    }

    ///<summary>Toggles (enable / disable) an automation.</summary>
    ///<param name="target">The target for this service call</param>
    public void Toggle(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("automation", "toggle", target, data);
    }

    ///<summary>Triggers the actions of an automation.</summary>
    ///<param name="target">The target for this service call</param>
    public void Trigger(ServiceTarget target, AutomationTriggerParameters data)
    {
        _haContext.CallService("automation", "trigger", target, data);
    }

    ///<summary>Triggers the actions of an automation.</summary>
    ///<param name="skipCondition">Defines whether or not the conditions will be skipped.</param>
    public void Trigger(ServiceTarget target, bool? skipCondition = null)
    {
        _haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters { SkipCondition = skipCondition });
    }

    ///<summary>Disables an automation.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOff(ServiceTarget target, AutomationTurnOffParameters data)
    {
        _haContext.CallService("automation", "turn_off", target, data);
    }

    ///<summary>Disables an automation.</summary>
    ///<param name="stopActions">Stops currently running actions.</param>
    public void TurnOff(ServiceTarget target, bool? stopActions = null)
    {
        _haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters { StopActions = stopActions });
    }

    ///<summary>Enables an automation.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOn(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("automation", "turn_on", target, data);
    }
}