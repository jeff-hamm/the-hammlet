//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.1089948-08:00
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
public class SwitchIds
{
    public string AdaptiveLightingAdaptBrightnessAdaptinglighting { get; } = "switch.adaptive_lighting_adapt_brightness_adaptinglighting";
    public string AdaptiveLightingAdaptColorAdaptinglighting { get; } = "switch.adaptive_lighting_adapt_color_adaptinglighting";
    public string AdaptiveLightingAdaptinglighting { get; } = "switch.adaptive_lighting_adaptinglighting";
    public string AdaptiveLightingSleepModeAdaptinglighting { get; } = "switch.adaptive_lighting_sleep_mode_adaptinglighting";
    public string AllOffIgnoreUnavailable { get; } = "switch.all_off_ignore_unavailable";
    public string AllOffRestoreOnDeactivate { get; } = "switch.all_off_restore_on_deactivate";
    public string AllOffStatefulScene { get; } = "switch.all_off_stateful_scene";
    public string BrightIgnoreUnavailable { get; } = "switch.bright_ignore_unavailable";
    public string BrightRestoreOnDeactivate { get; } = "switch.bright_restore_on_deactivate";
    public string BrightStatefulScene { get; } = "switch.bright_stateful_scene";
    public string DinnerTimeIgnoreUnavailable { get; } = "switch.dinner_time_ignore_unavailable";
    public string DinnerTimeRestoreOnDeactivate { get; } = "switch.dinner_time_restore_on_deactivate";
    public string DinnerTimeStatefulScene { get; } = "switch.dinner_time_stateful_scene";
    public string EveninkIgnoreUnavailable { get; } = "switch.evenink_ignore_unavailable";
    public string EveninkRestoreOnDeactivate { get; } = "switch.evenink_restore_on_deactivate";
    public string EveninkStatefulScene { get; } = "switch.evenink_stateful_scene";
    public string FingerRobot2Switch { get; } = "switch.finger_robot_2_switch";
    public string HammetBtProxyBleGatewayDiscovery { get; } = "switch.hammet_bt_proxy_ble_gateway_discovery";
    public string HammletBedlampLed { get; } = "switch.hammlet_bedlamp_led";
    public string HangoutIgnoreUnavailable { get; } = "switch.hangout_ignore_unavailable";
    public string HangoutRestoreOnDeactivate { get; } = "switch.hangout_restore_on_deactivate";
    public string HangoutStatefulScene { get; } = "switch.hangout_stateful_scene";
    public string HeyNabuMute { get; } = "switch.hey_nabu_mute";
    public string HeyNabuWakeSound { get; } = "switch.hey_nabu_wake_sound";
    public string KitchenSwitch { get; } = "switch.kitchen_switch";
    public string LiminalSwitch { get; } = "switch.liminal_switch";
    public string NightIgnoreUnavailable { get; } = "switch.night_ignore_unavailable";
    public string NightRestoreOnDeactivate { get; } = "switch.night_restore_on_deactivate";
    public string NightStatefulScene { get; } = "switch.night_stateful_scene";
    public string NormalButtsIgnoreUnavailable { get; } = "switch.normal_butts_ignore_unavailable";
    public string NormalButtsRestoreOnDeactivate { get; } = "switch.normal_butts_restore_on_deactivate";
    public string NormalButtsStatefulScene { get; } = "switch.normal_butts_stateful_scene";
    public string OutdoorSwitch { get; } = "switch.outdoor_switch";
    public string PantsEmergencyStartOffIgnoreUnavailable { get; } = "switch.pants_emergency_start_off_ignore_unavailable";
    public string PantsEmergencyStartOffRestoreOnDeactivate { get; } = "switch.pants_emergency_start_off_restore_on_deactivate";
    public string PantsEmergencyStartOffStatefulScene { get; } = "switch.pants_emergency_start_off_stateful_scene";
    public string PantsEmergencyStartOnIgnoreUnavailable { get; } = "switch.pants_emergency_start_on_ignore_unavailable";
    public string PantsEmergencyStartOnRestoreOnDeactivate { get; } = "switch.pants_emergency_start_on_restore_on_deactivate";
    public string PantsEmergencyStartOnStatefulScene { get; } = "switch.pants_emergency_start_on_stateful_scene";
    public string PantsOffEmergencyIgnoreUnavailable { get; } = "switch.pants_off_emergency_ignore_unavailable";
    public string PantsOffEmergencyRestoreOnDeactivate { get; } = "switch.pants_off_emergency_restore_on_deactivate";
    public string PantsOffEmergencyStatefulScene { get; } = "switch.pants_off_emergency_stateful_scene";
    public string PinkAndSexyIgnoreUnavailable { get; } = "switch.pink_and_sexy_ignore_unavailable";
    public string PinkAndSexyRestoreOnDeactivate { get; } = "switch.pink_and_sexy_restore_on_deactivate";
    public string PinkAndSexyStatefulScene { get; } = "switch.pink_and_sexy_stateful_scene";
    public string Speakers { get; } = "switch.speakers";
    public string TentacleLamp { get; } = "switch.tentacle_lamp";
    public string TentacleLampAutoUpdateEnabled { get; } = "switch.tentacle_lamp_auto_update_enabled";
    public string TentacleLampLed { get; } = "switch.tentacle_lamp_led";
    public string TentacleLed { get; } = "switch.tentacle_led";
    public string TurnOffAllLightsIgnoreUnavailable { get; } = "switch.turn_off_all_lights_ignore_unavailable";
    public string TurnOffAllLightsRestoreOnDeactivate { get; } = "switch.turn_off_all_lights_restore_on_deactivate";
    public string TurnOffAllLightsStatefulScene { get; } = "switch.turn_off_all_lights_stateful_scene";
    public string WorkingIgnoreUnavailable { get; } = "switch.working_ignore_unavailable";
    public string WorkingRestoreOnDeactivate { get; } = "switch.working_restore_on_deactivate";
    public string WorkingStatefulScene { get; } = "switch.working_stateful_scene";
    public string Zigbee2mqttBridgePermitJoin { get; } = "switch.zigbee2mqtt_bridge_permit_join";
}