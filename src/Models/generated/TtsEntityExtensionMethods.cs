//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T15:53:28.3257961-08:00
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
public static class TtsEntityExtensionMethods
{
    ///<summary>Speaks something using text-to-speech on a media player.</summary>
    public static void Speak(this TtsEntity target, TtsSpeakParameters data)
    {
        target.CallService("speak", data);
    }

    ///<summary>Speaks something using text-to-speech on a media player.</summary>
    public static void Speak(this IEnumerable<TtsEntity> target, TtsSpeakParameters data)
    {
        target.CallService("speak", data);
    }

    ///<summary>Speaks something using text-to-speech on a media player.</summary>
    ///<param name="target">The TtsEntity to call this service for</param>
    ///<param name="mediaPlayerEntityId">Media players to play the message.</param>
    ///<param name="message">The text you want to convert into speech so that you can listen to it on your device. eg: My name is hanna</param>
    ///<param name="cache">Stores this message locally so that when the text is requested again, the output can be produced more quickly.</param>
    ///<param name="language">Language to use for speech generation. eg: ru</param>
    ///<param name="options">A dictionary containing integration-specific options. eg: platform specific</param>
    public static void Speak(this TtsEntity target, string mediaPlayerEntityId, string message, bool? cache = null, string? language = null, object? options = null)
    {
        target.CallService("speak", new TtsSpeakParameters { MediaPlayerEntityId = mediaPlayerEntityId, Message = message, Cache = cache, Language = language, Options = options });
    }

    ///<summary>Speaks something using text-to-speech on a media player.</summary>
    ///<param name="target">The IEnumerable&lt;TtsEntity&gt; to call this service for</param>
    ///<param name="mediaPlayerEntityId">Media players to play the message.</param>
    ///<param name="message">The text you want to convert into speech so that you can listen to it on your device. eg: My name is hanna</param>
    ///<param name="cache">Stores this message locally so that when the text is requested again, the output can be produced more quickly.</param>
    ///<param name="language">Language to use for speech generation. eg: ru</param>
    ///<param name="options">A dictionary containing integration-specific options. eg: platform specific</param>
    public static void Speak(this IEnumerable<TtsEntity> target, string mediaPlayerEntityId, string message, bool? cache = null, string? language = null, object? options = null)
    {
        target.CallService("speak", new TtsSpeakParameters { MediaPlayerEntityId = mediaPlayerEntityId, Message = message, Cache = cache, Language = language, Options = options });
    }
}