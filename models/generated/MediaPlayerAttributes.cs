//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v24.52.0.0
//   At: 2025-01-16T04:15:55.8988657-08:00
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
public partial record MediaPlayerAttributes
{
    [JsonPropertyName("adb_response")]
    public object? AdbResponse { get; init; }

    [JsonPropertyName("hdmi_input")]
    public object? HdmiInput { get; init; }

    [JsonPropertyName("sound_mode_raw")]
    public string? SoundModeRaw { get; init; }

    [JsonPropertyName("assumed_state")]
    public bool? AssumedState { get; init; }

    [JsonPropertyName("remote_player_state")]
    public string? RemotePlayerState { get; init; }

    [JsonPropertyName("likeStatus")]
    public string? LikeStatus { get; init; }

    [JsonPropertyName("current_playlist_title")]
    public string? CurrentPlaylistTitle { get; init; }

    [JsonPropertyName("videoId")]
    public string? VideoId { get; init; }

    [JsonPropertyName("_media_type")]
    public string? MediaType { get; init; }

    [JsonPropertyName("_media_id")]
    public string? MediaId { get; init; }

    [JsonPropertyName("current_track")]
    public double? CurrentTrack { get; init; }

    [JsonPropertyName("remote_player_id")]
    public string? RemotePlayerId { get; init; }

    [JsonPropertyName("restored")]
    public bool? Restored { get; init; }

    [JsonPropertyName("active_child")]
    public string? ActiveChild { get; init; }

    [JsonPropertyName("sound_output")]
    public string? SoundOutput { get; init; }

    [JsonPropertyName("source_list")]
    public IReadOnlyList<string>? SourceList { get; init; }

    [JsonPropertyName("device_class")]
    public string? DeviceClass { get; init; }

    [JsonPropertyName("entity_picture")]
    public string? EntityPicture { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("supported_features")]
    public double? SupportedFeatures { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("volume_level")]
    public double? VolumeLevel { get; init; }

    [JsonPropertyName("is_volume_muted")]
    public bool? IsVolumeMuted { get; init; }

    [JsonPropertyName("media_content_id")]
    public string? MediaContentId { get; init; }

    [JsonPropertyName("media_content_type")]
    public string? MediaContentType { get; init; }

    [JsonPropertyName("media_duration")]
    public double? MediaDuration { get; init; }

    [JsonPropertyName("media_position")]
    public double? MediaPosition { get; init; }

    [JsonPropertyName("media_position_updated_at")]
    public string? MediaPositionUpdatedAt { get; init; }

    [JsonPropertyName("media_title")]
    public string? MediaTitle { get; init; }

    [JsonPropertyName("app_id")]
    public string? AppId { get; init; }

    [JsonPropertyName("app_name")]
    public string? AppName { get; init; }

    [JsonPropertyName("entity_picture_local")]
    public string? EntityPictureLocal { get; init; }

    [JsonPropertyName("media_artist")]
    public string? MediaArtist { get; init; }

    [JsonPropertyName("media_album_name")]
    public string? MediaAlbumName { get; init; }

    [JsonPropertyName("media_track")]
    public double? MediaTrack { get; init; }

    [JsonPropertyName("source")]
    public string? Source { get; init; }

    [JsonPropertyName("shuffle")]
    public bool? Shuffle { get; init; }

    [JsonPropertyName("repeat")]
    public string? Repeat { get; init; }
}