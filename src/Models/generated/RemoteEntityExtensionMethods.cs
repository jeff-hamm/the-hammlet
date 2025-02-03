//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.5425715-08:00
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
public static class RemoteEntityExtensionMethods
{
    ///<summary>Deletes a command or a list of commands from the database.</summary>
    public static void DeleteCommand(this IRemoteEntityCore target, RemoteDeleteCommandParameters data)
    {
        target.CallService("delete_command", data);
    }

    ///<summary>Deletes a command or a list of commands from the database.</summary>
    public static void DeleteCommand(this IEnumerable<IRemoteEntityCore> target, RemoteDeleteCommandParameters data)
    {
        target.CallService("delete_command", data);
    }

    ///<summary>Deletes a command or a list of commands from the database.</summary>
    ///<param name="target">The IRemoteEntityCore to call this service for</param>
    ///<param name="device">Device from which commands will be deleted. eg: television</param>
    ///<param name="command">The single command or the list of commands to be deleted. eg: Mute</param>
    public static void DeleteCommand(this IRemoteEntityCore target, object command, string? device = null)
    {
        target.CallService("delete_command", new RemoteDeleteCommandParameters { Device = device, Command = command });
    }

    ///<summary>Deletes a command or a list of commands from the database.</summary>
    ///<param name="target">The IEnumerable&lt;IRemoteEntityCore&gt; to call this service for</param>
    ///<param name="device">Device from which commands will be deleted. eg: television</param>
    ///<param name="command">The single command or the list of commands to be deleted. eg: Mute</param>
    public static void DeleteCommand(this IEnumerable<IRemoteEntityCore> target, object command, string? device = null)
    {
        target.CallService("delete_command", new RemoteDeleteCommandParameters { Device = device, Command = command });
    }

    ///<summary>Learns a command or a list of commands from a device.</summary>
    public static void LearnCommand(this IRemoteEntityCore target, RemoteLearnCommandParameters data)
    {
        target.CallService("learn_command", data);
    }

    ///<summary>Learns a command or a list of commands from a device.</summary>
    public static void LearnCommand(this IEnumerable<IRemoteEntityCore> target, RemoteLearnCommandParameters data)
    {
        target.CallService("learn_command", data);
    }

    ///<summary>Learns a command or a list of commands from a device.</summary>
    ///<param name="target">The IRemoteEntityCore to call this service for</param>
    ///<param name="device">Device ID to learn command from. eg: television</param>
    ///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
    ///<param name="commandType">The type of command to be learned.</param>
    ///<param name="alternative">If code must be stored as an alternative. This is useful for discrete codes. Discrete codes are used for toggles that only perform one function. For example, a code to only turn a device on. If it is on already, sending the code won&apos;t change the state.</param>
    ///<param name="timeout">Timeout for the command to be learned.</param>
    public static void LearnCommand(this IRemoteEntityCore target, string? device = null, object? command = null, object? commandType = null, bool? alternative = null, long? timeout = null)
    {
        target.CallService("learn_command", new RemoteLearnCommandParameters { Device = device, Command = command, CommandType = commandType, Alternative = alternative, Timeout = timeout });
    }

    ///<summary>Learns a command or a list of commands from a device.</summary>
    ///<param name="target">The IEnumerable&lt;IRemoteEntityCore&gt; to call this service for</param>
    ///<param name="device">Device ID to learn command from. eg: television</param>
    ///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
    ///<param name="commandType">The type of command to be learned.</param>
    ///<param name="alternative">If code must be stored as an alternative. This is useful for discrete codes. Discrete codes are used for toggles that only perform one function. For example, a code to only turn a device on. If it is on already, sending the code won&apos;t change the state.</param>
    ///<param name="timeout">Timeout for the command to be learned.</param>
    public static void LearnCommand(this IEnumerable<IRemoteEntityCore> target, string? device = null, object? command = null, object? commandType = null, bool? alternative = null, long? timeout = null)
    {
        target.CallService("learn_command", new RemoteLearnCommandParameters { Device = device, Command = command, CommandType = commandType, Alternative = alternative, Timeout = timeout });
    }

    ///<summary>Sends a command or a list of commands to a device.</summary>
    public static void SendCommand(this IRemoteEntityCore target, RemoteSendCommandParameters data)
    {
        target.CallService("send_command", data);
    }

    ///<summary>Sends a command or a list of commands to a device.</summary>
    public static void SendCommand(this IEnumerable<IRemoteEntityCore> target, RemoteSendCommandParameters data)
    {
        target.CallService("send_command", data);
    }

    ///<summary>Sends a command or a list of commands to a device.</summary>
    ///<param name="target">The IRemoteEntityCore to call this service for</param>
    ///<param name="device">Device ID to send command to. eg: 32756745</param>
    ///<param name="command">A single command or a list of commands to send. eg: Play</param>
    ///<param name="numRepeats">The number of times you want to repeat the commands.</param>
    ///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
    ///<param name="holdSecs">The time you want to have it held before the release is send.</param>
    public static void SendCommand(this IRemoteEntityCore target, object command, string? device = null, double? numRepeats = null, double? delaySecs = null, double? holdSecs = null)
    {
        target.CallService("send_command", new RemoteSendCommandParameters { Device = device, Command = command, NumRepeats = numRepeats, DelaySecs = delaySecs, HoldSecs = holdSecs });
    }

    ///<summary>Sends a command or a list of commands to a device.</summary>
    ///<param name="target">The IEnumerable&lt;IRemoteEntityCore&gt; to call this service for</param>
    ///<param name="device">Device ID to send command to. eg: 32756745</param>
    ///<param name="command">A single command or a list of commands to send. eg: Play</param>
    ///<param name="numRepeats">The number of times you want to repeat the commands.</param>
    ///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
    ///<param name="holdSecs">The time you want to have it held before the release is send.</param>
    public static void SendCommand(this IEnumerable<IRemoteEntityCore> target, object command, string? device = null, double? numRepeats = null, double? delaySecs = null, double? holdSecs = null)
    {
        target.CallService("send_command", new RemoteSendCommandParameters { Device = device, Command = command, NumRepeats = numRepeats, DelaySecs = delaySecs, HoldSecs = holdSecs });
    }

    ///<summary>Sends the toggle command.</summary>
    public static void Toggle(this IRemoteEntityCore target, object? data = null)
    {
        target.CallService("toggle", data);
    }

    ///<summary>Sends the toggle command.</summary>
    public static void Toggle(this IEnumerable<IRemoteEntityCore> target, object? data = null)
    {
        target.CallService("toggle", data);
    }

    ///<summary>Sends the turn off command.</summary>
    public static void TurnOff(this IRemoteEntityCore target, object? data = null)
    {
        target.CallService("turn_off", data);
    }

    ///<summary>Sends the turn off command.</summary>
    public static void TurnOff(this IEnumerable<IRemoteEntityCore> target, object? data = null)
    {
        target.CallService("turn_off", data);
    }

    ///<summary>Sends the turn on command.</summary>
    public static void TurnOn(this IRemoteEntityCore target, RemoteTurnOnParameters data)
    {
        target.CallService("turn_on", data);
    }

    ///<summary>Sends the turn on command.</summary>
    public static void TurnOn(this IEnumerable<IRemoteEntityCore> target, RemoteTurnOnParameters data)
    {
        target.CallService("turn_on", data);
    }

    ///<summary>Sends the turn on command.</summary>
    ///<param name="target">The IRemoteEntityCore to call this service for</param>
    ///<param name="activity">Activity ID or activity name to be started. eg: BedroomTV</param>
    public static void TurnOn(this IRemoteEntityCore target, string? activity = null)
    {
        target.CallService("turn_on", new RemoteTurnOnParameters { Activity = activity });
    }

    ///<summary>Sends the turn on command.</summary>
    ///<param name="target">The IEnumerable&lt;IRemoteEntityCore&gt; to call this service for</param>
    ///<param name="activity">Activity ID or activity name to be started. eg: BedroomTV</param>
    public static void TurnOn(this IEnumerable<IRemoteEntityCore> target, string? activity = null)
    {
        target.CallService("turn_on", new RemoteTurnOnParameters { Activity = activity });
    }
}