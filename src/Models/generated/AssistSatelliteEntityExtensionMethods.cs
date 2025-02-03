//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.4757530-08:00
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
public static class AssistSatelliteEntityExtensionMethods
{
    ///<summary>Let the satellite announce a message.</summary>
    public static void Announce(this AssistSatelliteEntity target, AssistSatelliteAnnounceParameters data)
    {
        target.CallService("announce", data);
    }

    ///<summary>Let the satellite announce a message.</summary>
    public static void Announce(this IEnumerable<AssistSatelliteEntity> target, AssistSatelliteAnnounceParameters data)
    {
        target.CallService("announce", data);
    }

    ///<summary>Let the satellite announce a message.</summary>
    ///<param name="target">The AssistSatelliteEntity to call this service for</param>
    ///<param name="message">The message to announce. eg: Time to wake up!</param>
    ///<param name="mediaId">The media ID to announce instead of using text-to-speech.</param>
    public static void Announce(this AssistSatelliteEntity target, string? message = null, string? mediaId = null)
    {
        target.CallService("announce", new AssistSatelliteAnnounceParameters { Message = message, MediaId = mediaId });
    }

    ///<summary>Let the satellite announce a message.</summary>
    ///<param name="target">The IEnumerable&lt;AssistSatelliteEntity&gt; to call this service for</param>
    ///<param name="message">The message to announce. eg: Time to wake up!</param>
    ///<param name="mediaId">The media ID to announce instead of using text-to-speech.</param>
    public static void Announce(this IEnumerable<AssistSatelliteEntity> target, string? message = null, string? mediaId = null)
    {
        target.CallService("announce", new AssistSatelliteAnnounceParameters { Message = message, MediaId = mediaId });
    }
}