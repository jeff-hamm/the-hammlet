//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-14T20:58:04.1567742-08:00
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
public partial class SirenServices
{
    private readonly IHaContext _haContext;
    public SirenServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Toggles the siren on/off.</summary>
    ///<param name="target">The target for this service call</param>
    public void Toggle(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("siren", "toggle", target, data);
    }

    ///<summary>Turns the siren off.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOff(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("siren", "turn_off", target, data);
    }

    ///<summary>Turns the siren on.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOn(ServiceTarget target, SirenTurnOnParameters data)
    {
        _haContext.CallService("siren", "turn_on", target, data);
    }

    ///<summary>Turns the siren on.</summary>
    ///<param name="tone">The tone to emit. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</param>
    ///<param name="volumeLevel">The volume. 0 is inaudible, 1 is the maximum volume. Must be supported by the integration. eg: 0.5</param>
    ///<param name="duration">Number of seconds the sound is played. Must be supported by the integration. eg: 15</param>
    public void TurnOn(ServiceTarget target, string? tone = null, double? volumeLevel = null, string? duration = null)
    {
        _haContext.CallService("siren", "turn_on", target, new SirenTurnOnParameters { Tone = tone, VolumeLevel = volumeLevel, Duration = duration });
    }
}