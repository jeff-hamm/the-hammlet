//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.2796980-08:00
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
public partial class ValveServices
{
    private readonly IHaContext _haContext;
    public ValveServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Closes a valve.</summary>
    ///<param name="target">The target for this service call</param>
    public void CloseValve(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("valve", "close_valve", target, data);
    }

    ///<summary>Opens a valve.</summary>
    ///<param name="target">The target for this service call</param>
    public void OpenValve(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("valve", "open_valve", target, data);
    }

    ///<summary>Moves a valve to a specific position.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetValvePosition(ServiceTarget target, ValveSetValvePositionParameters data)
    {
        _haContext.CallService("valve", "set_valve_position", target, data);
    }

    ///<summary>Moves a valve to a specific position.</summary>
    ///<param name="position">Target position.</param>
    public void SetValvePosition(ServiceTarget target, double position)
    {
        _haContext.CallService("valve", "set_valve_position", target, new ValveSetValvePositionParameters { Position = position });
    }

    ///<summary>Stops the valve movement.</summary>
    ///<param name="target">The target for this service call</param>
    public void StopValve(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("valve", "stop_valve", target, data);
    }

    ///<summary>Toggles a valve open/closed.</summary>
    ///<param name="target">The target for this service call</param>
    public void Toggle(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("valve", "toggle", target, data);
    }
}