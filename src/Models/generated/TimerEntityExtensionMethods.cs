//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.8734598-08:00
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
public static class TimerEntityExtensionMethods
{
    ///<summary>Resets a timer&apos;s duration to the last known initial value without firing the timer finished event.</summary>
    public static void Cancel(this ITimerEntityCore target, object? data = null)
    {
        target.CallService("cancel", data);
    }

    ///<summary>Resets a timer&apos;s duration to the last known initial value without firing the timer finished event.</summary>
    public static void Cancel(this IEnumerable<ITimerEntityCore> target, object? data = null)
    {
        target.CallService("cancel", data);
    }

    ///<summary>Changes a timer by adding or subtracting a given duration.</summary>
    public static void Change(this ITimerEntityCore target, TimerChangeParameters data)
    {
        target.CallService("change", data);
    }

    ///<summary>Changes a timer by adding or subtracting a given duration.</summary>
    public static void Change(this IEnumerable<ITimerEntityCore> target, TimerChangeParameters data)
    {
        target.CallService("change", data);
    }

    ///<summary>Changes a timer by adding or subtracting a given duration.</summary>
    ///<param name="target">The ITimerEntityCore to call this service for</param>
    ///<param name="duration">Duration to add to or subtract from the running timer. eg: 00:01:00, 60 or -60</param>
    public static void Change(this ITimerEntityCore target, string duration)
    {
        target.CallService("change", new TimerChangeParameters { Duration = duration });
    }

    ///<summary>Changes a timer by adding or subtracting a given duration.</summary>
    ///<param name="target">The IEnumerable&lt;ITimerEntityCore&gt; to call this service for</param>
    ///<param name="duration">Duration to add to or subtract from the running timer. eg: 00:01:00, 60 or -60</param>
    public static void Change(this IEnumerable<ITimerEntityCore> target, string duration)
    {
        target.CallService("change", new TimerChangeParameters { Duration = duration });
    }

    ///<summary>Finishes a running timer earlier than scheduled.</summary>
    public static void Finish(this ITimerEntityCore target, object? data = null)
    {
        target.CallService("finish", data);
    }

    ///<summary>Finishes a running timer earlier than scheduled.</summary>
    public static void Finish(this IEnumerable<ITimerEntityCore> target, object? data = null)
    {
        target.CallService("finish", data);
    }

    ///<summary>Pauses a running timer, retaining the remaining duration for later continuation.</summary>
    public static void Pause(this ITimerEntityCore target, object? data = null)
    {
        target.CallService("pause", data);
    }

    ///<summary>Pauses a running timer, retaining the remaining duration for later continuation.</summary>
    public static void Pause(this IEnumerable<ITimerEntityCore> target, object? data = null)
    {
        target.CallService("pause", data);
    }

    ///<summary>Starts a timer or restarts it with a provided duration.</summary>
    public static void Start(this ITimerEntityCore target, TimerStartParameters data)
    {
        target.CallService("start", data);
    }

    ///<summary>Starts a timer or restarts it with a provided duration.</summary>
    public static void Start(this IEnumerable<ITimerEntityCore> target, TimerStartParameters data)
    {
        target.CallService("start", data);
    }

    ///<summary>Starts a timer or restarts it with a provided duration.</summary>
    ///<param name="target">The ITimerEntityCore to call this service for</param>
    ///<param name="duration">Custom duration to restart the timer with. eg: 00:01:00 or 60</param>
    public static void Start(this ITimerEntityCore target, string? duration = null)
    {
        target.CallService("start", new TimerStartParameters { Duration = duration });
    }

    ///<summary>Starts a timer or restarts it with a provided duration.</summary>
    ///<param name="target">The IEnumerable&lt;ITimerEntityCore&gt; to call this service for</param>
    ///<param name="duration">Custom duration to restart the timer with. eg: 00:01:00 or 60</param>
    public static void Start(this IEnumerable<ITimerEntityCore> target, string? duration = null)
    {
        target.CallService("start", new TimerStartParameters { Duration = duration });
    }
}