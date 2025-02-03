//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T15:53:28.0923471-08:00
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
public partial class VacuumServices
{
    private readonly IHaContext _haContext;
    public VacuumServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Tells the vacuum cleaner to do a spot clean-up.</summary>
    ///<param name="target">The target for this service call</param>
    public void CleanSpot(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("vacuum", "clean_spot", target, data);
    }

    ///<summary>Locates the vacuum cleaner robot.</summary>
    ///<param name="target">The target for this service call</param>
    public void Locate(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("vacuum", "locate", target, data);
    }

    ///<summary>Pauses the cleaning task.</summary>
    ///<param name="target">The target for this service call</param>
    public void Pause(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("vacuum", "pause", target, data);
    }

    ///<summary>Tells the vacuum cleaner to return to its dock.</summary>
    ///<param name="target">The target for this service call</param>
    public void ReturnToBase(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("vacuum", "return_to_base", target, data);
    }

    ///<summary>Sends a command to the vacuum cleaner.</summary>
    ///<param name="target">The target for this service call</param>
    public void SendCommand(ServiceTarget target, VacuumSendCommandParameters data)
    {
        _haContext.CallService("vacuum", "send_command", target, data);
    }

    ///<summary>Sends a command to the vacuum cleaner.</summary>
    ///<param name="command">Command to execute. The commands are integration-specific. eg: set_dnd_timer</param>
    ///<param name="params">Parameters for the command. The parameters are integration-specific. eg: { &quot;key&quot;: &quot;value&quot; }</param>
    public void SendCommand(ServiceTarget target, string command, object? @params = null)
    {
        _haContext.CallService("vacuum", "send_command", target, new VacuumSendCommandParameters { Command = command, Params = @params });
    }

    ///<summary>Sets the fan speed of the vacuum cleaner.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetFanSpeed(ServiceTarget target, VacuumSetFanSpeedParameters data)
    {
        _haContext.CallService("vacuum", "set_fan_speed", target, data);
    }

    ///<summary>Sets the fan speed of the vacuum cleaner.</summary>
    ///<param name="fanSpeed">Fan speed. The value depends on the integration. Some integrations have speed steps, like &apos;medium&apos;. Some use a percentage, between 0 and 100. eg: low</param>
    public void SetFanSpeed(ServiceTarget target, string fanSpeed)
    {
        _haContext.CallService("vacuum", "set_fan_speed", target, new VacuumSetFanSpeedParameters { FanSpeed = fanSpeed });
    }

    ///<summary>Starts or resumes the cleaning task.</summary>
    ///<param name="target">The target for this service call</param>
    public void Start(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("vacuum", "start", target, data);
    }

    ///<summary>Stops the current cleaning task.</summary>
    ///<param name="target">The target for this service call</param>
    public void Stop(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("vacuum", "stop", target, data);
    }
}