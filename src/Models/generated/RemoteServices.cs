//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T15:53:28.0362065-08:00
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
public partial class RemoteServices
{
    private readonly IHaContext _haContext;
    public RemoteServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Deletes a command or a list of commands from the database.</summary>
    ///<param name="target">The target for this service call</param>
    public void DeleteCommand(ServiceTarget target, RemoteDeleteCommandParameters data)
    {
        _haContext.CallService("remote", "delete_command", target, data);
    }

    ///<summary>Deletes a command or a list of commands from the database.</summary>
    ///<param name="device">Device from which commands will be deleted. eg: television</param>
    ///<param name="command">The single command or the list of commands to be deleted. eg: Mute</param>
    public void DeleteCommand(ServiceTarget target, object command, string? device = null)
    {
        _haContext.CallService("remote", "delete_command", target, new RemoteDeleteCommandParameters { Device = device, Command = command });
    }

    ///<summary>Learns a command or a list of commands from a device.</summary>
    ///<param name="target">The target for this service call</param>
    public void LearnCommand(ServiceTarget target, RemoteLearnCommandParameters data)
    {
        _haContext.CallService("remote", "learn_command", target, data);
    }

    ///<summary>Learns a command or a list of commands from a device.</summary>
    ///<param name="device">Device ID to learn command from. eg: television</param>
    ///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
    ///<param name="commandType">The type of command to be learned.</param>
    ///<param name="alternative">If code must be stored as an alternative. This is useful for discrete codes. Discrete codes are used for toggles that only perform one function. For example, a code to only turn a device on. If it is on already, sending the code won&apos;t change the state.</param>
    ///<param name="timeout">Timeout for the command to be learned.</param>
    public void LearnCommand(ServiceTarget target, string? device = null, object? command = null, object? commandType = null, bool? alternative = null, long? timeout = null)
    {
        _haContext.CallService("remote", "learn_command", target, new RemoteLearnCommandParameters { Device = device, Command = command, CommandType = commandType, Alternative = alternative, Timeout = timeout });
    }

    ///<summary>Sends a command or a list of commands to a device.</summary>
    ///<param name="target">The target for this service call</param>
    public void SendCommand(ServiceTarget target, RemoteSendCommandParameters data)
    {
        _haContext.CallService("remote", "send_command", target, data);
    }

    ///<summary>Sends a command or a list of commands to a device.</summary>
    ///<param name="device">Device ID to send command to. eg: 32756745</param>
    ///<param name="command">A single command or a list of commands to send. eg: Play</param>
    ///<param name="numRepeats">The number of times you want to repeat the commands.</param>
    ///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
    ///<param name="holdSecs">The time you want to have it held before the release is send.</param>
    public void SendCommand(ServiceTarget target, object command, string? device = null, double? numRepeats = null, double? delaySecs = null, double? holdSecs = null)
    {
        _haContext.CallService("remote", "send_command", target, new RemoteSendCommandParameters { Device = device, Command = command, NumRepeats = numRepeats, DelaySecs = delaySecs, HoldSecs = holdSecs });
    }

    ///<summary>Sends the toggle command.</summary>
    ///<param name="target">The target for this service call</param>
    public void Toggle(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("remote", "toggle", target, data);
    }

    ///<summary>Sends the turn off command.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOff(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("remote", "turn_off", target, data);
    }

    ///<summary>Sends the turn on command.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOn(ServiceTarget target, RemoteTurnOnParameters data)
    {
        _haContext.CallService("remote", "turn_on", target, data);
    }

    ///<summary>Sends the turn on command.</summary>
    ///<param name="activity">Activity ID or activity name to be started. eg: BedroomTV</param>
    public void TurnOn(ServiceTarget target, string? activity = null)
    {
        _haContext.CallService("remote", "turn_on", target, new RemoteTurnOnParameters { Activity = activity });
    }
}