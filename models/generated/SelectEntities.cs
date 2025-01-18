//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v24.52.0.0
//   At: 2025-01-16T04:15:55.8504046-08:00
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
public partial class SelectEntities
{
    private readonly IHaContext _haContext;
    public SelectEntities(IHaContext haContext)
    {
        _haContext = haContext;
    }

    /// <summary>Enumerates all select entities currently registered (at runtime) in Home Assistant as SelectEntity</summary>
    public IEnumerable<SelectEntity> EnumerateAll() => _haContext.GetAllEntities().Where(e => e.EntityId.StartsWith("select.")).Select(e => new SelectEntity(e));
    ///<summary>Plant Sensor 1 Temperature unit</summary>
    public SelectEntity _0xa4c1380cf616e594TemperatureUnit => new(_haContext, "select.0xa4c1380cf616e594_temperature_unit");
    ///<summary>All Off Off Scene</summary>
    public SelectEntity AllOffOffScene => new(_haContext, "select.all_off_off_scene");
    ///<summary>Bright Off Scene</summary>
    public SelectEntity BrightOffScene => new(_haContext, "select.bright_off_scene");
    ///<summary>default_light Color power on behavior</summary>
    public SelectEntity DefaultLightColorPowerOnBehavior => new(_haContext, "select.default_light_color_power_on_behavior");
    ///<summary>Dinner Time Off Scene</summary>
    public SelectEntity DinnerTimeOffScene => new(_haContext, "select.dinner_time_off_scene");
    ///<summary>Evenink Off Scene</summary>
    public SelectEntity EveninkOffScene => new(_haContext, "select.evenink_off_scene");
    ///<summary>Finger Robot 2 Mode</summary>
    public SelectEntity FingerRobot2Mode => new(_haContext, "select.finger_robot_2_mode");
    ///<summary>Hangout Off Scene</summary>
    public SelectEntity HangoutOffScene => new(_haContext, "select.hangout_off_scene");
    ///<summary>Kitchen Switch Power-on behavior</summary>
    public SelectEntity KitchenSwitchPowerOnBehavior => new(_haContext, "select.kitchen_switch_power_on_behavior");
    ///<summary>Liminal Switch Power-on behavior</summary>
    public SelectEntity LiminalSwitchPowerOnBehavior => new(_haContext, "select.liminal_switch_power_on_behavior");
    ///<summary>Night Off Scene</summary>
    public SelectEntity NightOffScene => new(_haContext, "select.night_off_scene");
    ///<summary>Normal Butts Off Scene</summary>
    public SelectEntity NormalButtsOffScene => new(_haContext, "select.normal_butts_off_scene");
    ///<summary>Outdoor Succulent Sensor Temperature unit</summary>
    public SelectEntity OutdoorSucculentSensorTemperatureUnit => new(_haContext, "select.outdoor_succulent_sensor_temperature_unit");
    ///<summary>Outdoor Switch Power-on behavior</summary>
    public SelectEntity OutdoorSwitchPowerOnBehavior => new(_haContext, "select.outdoor_switch_power_on_behavior");
    ///<summary>Pants Emergency Start Off Off Scene</summary>
    public SelectEntity PantsEmergencyStartOffOffScene => new(_haContext, "select.pants_emergency_start_off_off_scene");
    ///<summary>Pants Emergency Start On Off Scene</summary>
    public SelectEntity PantsEmergencyStartOnOffScene => new(_haContext, "select.pants_emergency_start_on_off_scene");
    ///<summary>Pants Off Emergency Off Scene</summary>
    public SelectEntity PantsOffEmergencyOffScene => new(_haContext, "select.pants_off_emergency_off_scene");
    ///<summary>Pink and sexy Off Scene</summary>
    public SelectEntity PinkAndSexyOffScene => new(_haContext, "select.pink_and_sexy_off_scene");
    ///<summary>Power-on behavior on startup</summary>
    public SelectEntity SmartRgbtwBulbPowerOnBehaviorOnStartup => new(_haContext, "select.smart_rgbtw_bulb_power_on_behavior_on_startup");
    ///<summary>Power-on behavior on startup</summary>
    public SelectEntity SmartRgbtwBulbPowerOnBehaviorOnStartup2 => new(_haContext, "select.smart_rgbtw_bulb_power_on_behavior_on_startup_2");
    ///<summary>Power-on behavior on startup</summary>
    public SelectEntity SmartWiFiLampDimmerPowerOnBehaviorOnStartup => new(_haContext, "select.smart_wi_fi_lamp_dimmer_power_on_behavior_on_startup");
    ///<summary>Power-on behavior on startup</summary>
    public SelectEntity SmartWiFiLampDimmerPowerOnBehaviorOnStartup2 => new(_haContext, "select.smart_wi_fi_lamp_dimmer_power_on_behavior_on_startup_2");
    ///<summary>Smart Wi-Fi Lamp Dimmer Power-on behavior on startup</summary>
    public SelectEntity SmartWiFiLampDimmerPowerOnBehaviorOnStartup3 => new(_haContext, "select.smart_wi_fi_lamp_dimmer_power_on_behavior_on_startup_3");
    ///<summary>Tapo Smart_Dimmer Light preset</summary>
    public SelectEntity TapoSmartDimmerLightPreset => new(_haContext, "select.tapo_smart_dimmer_light_preset");
    ///<summary>Turn off all lights Off Scene</summary>
    public SelectEntity TurnOffAllLightsOffScene => new(_haContext, "select.turn_off_all_lights_off_scene");
    ///<summary>Working Off Scene</summary>
    public SelectEntity WorkingOffScene => new(_haContext, "select.working_off_scene");
    ///<summary>ytube_music_player Play Mode</summary>
    public SelectEntity YtubeMusicPlayerPlayMode => new(_haContext, "select.ytube_music_player_play_mode");
    ///<summary>ytube_music_player Playlist</summary>
    public SelectEntity YtubeMusicPlayerPlaylist => new(_haContext, "select.ytube_music_player_playlist");
    ///<summary>ytube_music_player Radio Mode</summary>
    public SelectEntity YtubeMusicPlayerRadioMode => new(_haContext, "select.ytube_music_player_radio_mode");
    ///<summary>ytube_music_player Repeat Mode</summary>
    public SelectEntity YtubeMusicPlayerRepeatMode => new(_haContext, "select.ytube_music_player_repeat_mode");
    ///<summary>ytube_music_player Speaker</summary>
    public SelectEntity YtubeMusicPlayerSpeaker => new(_haContext, "select.ytube_music_player_speaker");
    ///<summary>Zigbee2MQTT Bridge Log level</summary>
    public SelectEntity Zigbee2mqttBridgeLogLevel => new(_haContext, "select.zigbee2mqtt_bridge_log_level");
}