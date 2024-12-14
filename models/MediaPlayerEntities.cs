//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v24.50.0.0
//   At: 2024-12-14T14:51:18.4656485-08:00
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
public partial class MediaPlayerEntities
{
    private readonly IHaContext _haContext;
    public MediaPlayerEntities(IHaContext haContext)
    {
        _haContext = haContext;
    }

    /// <summary>Enumerates all media_player entities currently registered (at runtime) in Home Assistant as MediaPlayerEntity</summary>
    public IEnumerable<MediaPlayerEntity> EnumerateAll() => _haContext.GetAllEntities().Where(e => e.EntityId.StartsWith("media_player.")).Select(e => new MediaPlayerEntity(e));
    ///<summary>Hammlet Cast</summary>
    public MediaPlayerEntity HammletCast => new(_haContext, "media_player.hammlet_cast");
    ///<summary>Hammlet Cast Remote</summary>
    public MediaPlayerEntity HammletCastRemote => new(_haContext, "media_player.hammlet_cast_remote");
    ///<summary>TV</summary>
    public MediaPlayerEntity HammletOledTv => new(_haContext, "media_player.hammlet_oled_tv");
    ///<summary>LG webOS TV EA88</summary>
    public MediaPlayerEntity LgWebosTvEa88 => new(_haContext, "media_player.lg_webos_tv_ea88");
    ///<summary>Spotify Scarlet Checkers</summary>
    public MediaPlayerEntity SpotifyScarletCheckers => new(_haContext, "media_player.spotify_scarlet_checkers");
    ///<summary>ytube_music_player</summary>
    public MediaPlayerEntity YtubeMusicPlayer => new(_haContext, "media_player.ytube_music_player");
}