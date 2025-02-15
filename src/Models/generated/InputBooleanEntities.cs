//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.0453286-08:00
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
public partial class InputBooleanEntities : IEntityDomain<InputBooleanEntity>
{
    private readonly IHaContext _haContext;
    public InputBooleanEntities(IHaContext haContext)
    {
        _haContext = haContext;
    }

    /// <summary>Enumerates all input_boolean entities currently registered (at runtime) in Home Assistant as InputBooleanEntity</summary>
    public IEnumerable<InputBooleanEntity> EnumerateAll() => _haContext.GetAllEntities().Where(e => e.EntityId.StartsWith("input_boolean.")).Select(e => new InputBooleanEntity(e));
    public InputBooleanEntity Entity(string entityId)
    {
        return (InputBooleanEntity)_haContext.Entity(entityId);
    }

    ///<summary>controller_flash</summary>
    public InputBooleanEntity ControllerFlash => new(_haContext, "input_boolean.controller_flash");
    ///<summary>netdaemon_hammlet_apps_assistant_monitor_available_assistants</summary>
    public InputBooleanEntity NetdaemonHammletAppsAssistantMonitorAvailableAssistants => new(_haContext, "input_boolean.netdaemon_hammlet_apps_assistant_monitor_available_assistants");
    ///<summary>netdaemon_hammlet_apps_lights_liminal_dimmer</summary>
    public InputBooleanEntity NetdaemonHammletAppsLightsLiminalDimmer => new(_haContext, "input_boolean.netdaemon_hammlet_apps_lights_liminal_dimmer");
    ///<summary>netdaemon_hammlet_apps_lights_set_to_warm_white</summary>
    public InputBooleanEntity NetdaemonHammletAppsLightsSetToWarmWhite => new(_haContext, "input_boolean.netdaemon_hammlet_apps_lights_set_to_warm_white");
    ///<summary>netdaemon_hammlet_apps_lights_watch_reference_light</summary>
    public InputBooleanEntity NetdaemonHammletAppsLightsWatchReferenceLight => new(_haContext, "input_boolean.netdaemon_hammlet_apps_lights_watch_reference_light");
    ///<summary>netdaemon_hammlet_apps_scene_on_button_scene_on_button</summary>
    public InputBooleanEntity NetdaemonHammletAppsSceneOnButtonSceneOnButton => new(_haContext, "input_boolean.netdaemon_hammlet_apps_scene_on_button_scene_on_button");
    ///<summary>netdaemon_hammlet_apps_voice_set_warm_white</summary>
    public InputBooleanEntity NetdaemonHammletAppsVoiceSetWarmWhite => new(_haContext, "input_boolean.netdaemon_hammlet_apps_voice_set_warm_white");
    ///<summary>netdaemon_hammlet_net_daemon_apps_media_management_turn_on_tv_for_video</summary>
    public InputBooleanEntity NetdaemonHammletNetDaemonAppsMediaManagementTurnOnTvForVideo => new(_haContext, "input_boolean.netdaemon_hammlet_net_daemon_apps_media_management_turn_on_tv_for_video");
    ///<summary>netdaemon_hammlet_net_daemon_apps_media_on_youtube_music_playlist_changed</summary>
    public InputBooleanEntity NetdaemonHammletNetDaemonAppsMediaOnYoutubeMusicPlaylistChanged => new(_haContext, "input_boolean.netdaemon_hammlet_net_daemon_apps_media_on_youtube_music_playlist_changed");
    ///<summary>pants_emergency</summary>
    public InputBooleanEntity PantsEmergency => new(_haContext, "input_boolean.pants_emergency");
    ///<summary>party-mode</summary>
    public InputBooleanEntity PartyMode => new(_haContext, "input_boolean.party_mode");
    public InputBooleanIds Ids => new();
}