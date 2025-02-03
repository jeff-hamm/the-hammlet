//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.1428794-08:00
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
public partial record MediaPlayerPlayMediaParameters
{
    ///<summary>The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</summary>
    [JsonPropertyName("media_content_id")]
    public string? MediaContentId { get; init; }

    ///<summary>The type of the content to play. Such as image, music, tv show, video, episode, channel, or playlist. eg: music</summary>
    [JsonPropertyName("media_content_type")]
    public string? MediaContentType { get; init; }

    ///<summary>If the content should be played now or be added to the queue.</summary>
    [JsonPropertyName("enqueue")]
    public object? Enqueue { get; init; }

    ///<summary>If the media should be played as an announcement. eg: true</summary>
    [JsonPropertyName("announce")]
    public bool? Announce { get; init; }
}