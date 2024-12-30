//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v24.50.0.0
//   At: 2024-12-29T20:57:07.5596774-08:00
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
public partial class NumberEntities
{
    private readonly IHaContext _haContext;
    public NumberEntities(IHaContext haContext)
    {
        _haContext = haContext;
    }

    /// <summary>Enumerates all number entities currently registered (at runtime) in Home Assistant as NumberEntity</summary>
    public IEnumerable<NumberEntity> EnumerateAll() => _haContext.GetAllEntities().Where(e => e.EntityId.StartsWith("number.")).Select(e => new NumberEntity(e));
    ///<summary>Alive Remote Indicator value</summary>
    public NumberEntity AliveRemoteRemoteControlSwitchIndicatorValue => new(_haContext, "number.alive_remote_remote_control_switch_indicator_value");
    ///<summary>All Off Debounce Time</summary>
    public NumberEntity AllOffDebounceTime => new(_haContext, "number.all_off_debounce_time");
    ///<summary>All Off Tolerance</summary>
    public NumberEntity AllOffTolerance => new(_haContext, "number.all_off_tolerance");
    ///<summary>All Off Transition Time</summary>
    public NumberEntity AllOffTransitionTime => new(_haContext, "number.all_off_transition_time");
    ///<summary>Bright Debounce Time</summary>
    public NumberEntity BrightDebounceTime => new(_haContext, "number.bright_debounce_time");
    ///<summary>Bright Tolerance</summary>
    public NumberEntity BrightTolerance => new(_haContext, "number.bright_tolerance");
    ///<summary>Bright Transition Time</summary>
    public NumberEntity BrightTransitionTime => new(_haContext, "number.bright_transition_time");
    ///<summary>Dinner Time Debounce Time</summary>
    public NumberEntity DinnerTimeDebounceTime => new(_haContext, "number.dinner_time_debounce_time");
    ///<summary>Dinner Time Tolerance</summary>
    public NumberEntity DinnerTimeTolerance => new(_haContext, "number.dinner_time_tolerance");
    ///<summary>Dinner Time Transition Time</summary>
    public NumberEntity DinnerTimeTransitionTime => new(_haContext, "number.dinner_time_transition_time");
    ///<summary>Evenink Debounce Time</summary>
    public NumberEntity EveninkDebounceTime => new(_haContext, "number.evenink_debounce_time");
    ///<summary>Evenink Tolerance</summary>
    public NumberEntity EveninkTolerance => new(_haContext, "number.evenink_tolerance");
    ///<summary>Evenink Transition Time</summary>
    public NumberEntity EveninkTransitionTime => new(_haContext, "number.evenink_transition_time");
    ///<summary>Finger Robot 2 Down delay</summary>
    public NumberEntity FingerRobot2DownDelay => new(_haContext, "number.finger_robot_2_down_delay");
    ///<summary>Finger Robot 2 Move down</summary>
    public NumberEntity FingerRobot2MoveDown => new(_haContext, "number.finger_robot_2_move_down");
    ///<summary>Finger Robot 2 Move up</summary>
    public NumberEntity FingerRobot2MoveUp => new(_haContext, "number.finger_robot_2_move_up");
    ///<summary>Hangout Debounce Time</summary>
    public NumberEntity HangoutDebounceTime => new(_haContext, "number.hangout_debounce_time");
    ///<summary>Hangout Tolerance</summary>
    public NumberEntity HangoutTolerance => new(_haContext, "number.hangout_tolerance");
    ///<summary>Hangout Transition Time</summary>
    public NumberEntity HangoutTransitionTime => new(_haContext, "number.hangout_transition_time");
    ///<summary>Night Debounce Time</summary>
    public NumberEntity NightDebounceTime => new(_haContext, "number.night_debounce_time");
    ///<summary>Night Tolerance</summary>
    public NumberEntity NightTolerance => new(_haContext, "number.night_tolerance");
    ///<summary>Night Transition Time</summary>
    public NumberEntity NightTransitionTime => new(_haContext, "number.night_transition_time");
    ///<summary>Normal Butts Debounce Time</summary>
    public NumberEntity NormalButtsDebounceTime => new(_haContext, "number.normal_butts_debounce_time");
    ///<summary>Normal Butts Tolerance</summary>
    public NumberEntity NormalButtsTolerance => new(_haContext, "number.normal_butts_tolerance");
    ///<summary>Normal Butts Transition Time</summary>
    public NumberEntity NormalButtsTransitionTime => new(_haContext, "number.normal_butts_transition_time");
    ///<summary>Pants Emergency Start Off Debounce Time</summary>
    public NumberEntity PantsEmergencyStartOffDebounceTime => new(_haContext, "number.pants_emergency_start_off_debounce_time");
    ///<summary>Pants Emergency Start Off Tolerance</summary>
    public NumberEntity PantsEmergencyStartOffTolerance => new(_haContext, "number.pants_emergency_start_off_tolerance");
    ///<summary>Pants Emergency Start Off Transition Time</summary>
    public NumberEntity PantsEmergencyStartOffTransitionTime => new(_haContext, "number.pants_emergency_start_off_transition_time");
    ///<summary>Pants Emergency Start On Debounce Time</summary>
    public NumberEntity PantsEmergencyStartOnDebounceTime => new(_haContext, "number.pants_emergency_start_on_debounce_time");
    ///<summary>Pants Emergency Start On Tolerance</summary>
    public NumberEntity PantsEmergencyStartOnTolerance => new(_haContext, "number.pants_emergency_start_on_tolerance");
    ///<summary>Pants Emergency Start On Transition Time</summary>
    public NumberEntity PantsEmergencyStartOnTransitionTime => new(_haContext, "number.pants_emergency_start_on_transition_time");
    ///<summary>Pants Off Emergency Debounce Time</summary>
    public NumberEntity PantsOffEmergencyDebounceTime => new(_haContext, "number.pants_off_emergency_debounce_time");
    ///<summary>Pants Off Emergency Tolerance</summary>
    public NumberEntity PantsOffEmergencyTolerance => new(_haContext, "number.pants_off_emergency_tolerance");
    ///<summary>Pants Off Emergency Transition Time</summary>
    public NumberEntity PantsOffEmergencyTransitionTime => new(_haContext, "number.pants_off_emergency_transition_time");
    ///<summary>Pink and sexy Debounce Time</summary>
    public NumberEntity PinkAndSexyDebounceTime => new(_haContext, "number.pink_and_sexy_debounce_time");
    ///<summary>Pink and sexy Tolerance</summary>
    public NumberEntity PinkAndSexyTolerance => new(_haContext, "number.pink_and_sexy_tolerance");
    ///<summary>Pink and sexy Transition Time</summary>
    public NumberEntity PinkAndSexyTransitionTime => new(_haContext, "number.pink_and_sexy_transition_time");
    ///<summary>Smart RGBTW Bulb Off transition time</summary>
    public NumberEntity SmartRgbtwBulbOffTransitionTime => new(_haContext, "number.smart_rgbtw_bulb_off_transition_time");
    ///<summary>Smart RGBTW Bulb Off transition time</summary>
    public NumberEntity SmartRgbtwBulbOffTransitionTime2 => new(_haContext, "number.smart_rgbtw_bulb_off_transition_time_2");
    ///<summary>Smart RGBTW Bulb On level</summary>
    public NumberEntity SmartRgbtwBulbOnLevel => new(_haContext, "number.smart_rgbtw_bulb_on_level");
    ///<summary>Smart RGBTW Bulb On level</summary>
    public NumberEntity SmartRgbtwBulbOnLevel2 => new(_haContext, "number.smart_rgbtw_bulb_on_level_2");
    ///<summary>Smart RGBTW Bulb On/Off transition time</summary>
    public NumberEntity SmartRgbtwBulbOnOffTransitionTime => new(_haContext, "number.smart_rgbtw_bulb_on_off_transition_time");
    ///<summary>Smart RGBTW Bulb On/Off transition time</summary>
    public NumberEntity SmartRgbtwBulbOnOffTransitionTime2 => new(_haContext, "number.smart_rgbtw_bulb_on_off_transition_time_2");
    ///<summary>Smart RGBTW Bulb On transition time</summary>
    public NumberEntity SmartRgbtwBulbOnTransitionTime => new(_haContext, "number.smart_rgbtw_bulb_on_transition_time");
    ///<summary>Smart RGBTW Bulb On transition time</summary>
    public NumberEntity SmartRgbtwBulbOnTransitionTime2 => new(_haContext, "number.smart_rgbtw_bulb_on_transition_time_2");
    ///<summary>Smart Wi-Fi Lamp Dimmer Off transition time</summary>
    public NumberEntity SmartWiFiLampDimmerOffTransitionTime => new(_haContext, "number.smart_wi_fi_lamp_dimmer_off_transition_time");
    ///<summary>Smart Wi-Fi Lamp Dimmer Off transition time</summary>
    public NumberEntity SmartWiFiLampDimmerOffTransitionTime2 => new(_haContext, "number.smart_wi_fi_lamp_dimmer_off_transition_time_2");
    ///<summary>Smart Wi-Fi Lamp Dimmer On level</summary>
    public NumberEntity SmartWiFiLampDimmerOnLevel => new(_haContext, "number.smart_wi_fi_lamp_dimmer_on_level");
    ///<summary>Smart Wi-Fi Lamp Dimmer On level</summary>
    public NumberEntity SmartWiFiLampDimmerOnLevel2 => new(_haContext, "number.smart_wi_fi_lamp_dimmer_on_level_2");
    ///<summary>Smart Wi-Fi Lamp Dimmer On transition time</summary>
    public NumberEntity SmartWiFiLampDimmerOnTransitionTime => new(_haContext, "number.smart_wi_fi_lamp_dimmer_on_transition_time");
    ///<summary>Smart Wi-Fi Lamp Dimmer On transition time</summary>
    public NumberEntity SmartWiFiLampDimmerOnTransitionTime2 => new(_haContext, "number.smart_wi_fi_lamp_dimmer_on_transition_time_2");
    ///<summary>Tentacle Lamp Smooth off</summary>
    public NumberEntity TapoSmartDimmerSmoothOff => new(_haContext, "number.tapo_smart_dimmer_smooth_off");
    ///<summary>Tentacle Lamp Smooth on</summary>
    public NumberEntity TapoSmartDimmerSmoothOn => new(_haContext, "number.tapo_smart_dimmer_smooth_on");
    ///<summary>Turn off all lights Debounce Time</summary>
    public NumberEntity TurnOffAllLightsDebounceTime => new(_haContext, "number.turn_off_all_lights_debounce_time");
    ///<summary>Turn off all lights Tolerance</summary>
    public NumberEntity TurnOffAllLightsTolerance => new(_haContext, "number.turn_off_all_lights_tolerance");
    ///<summary>Turn off all lights Transition Time</summary>
    public NumberEntity TurnOffAllLightsTransitionTime => new(_haContext, "number.turn_off_all_lights_transition_time");
    ///<summary>Working Debounce Time</summary>
    public NumberEntity WorkingDebounceTime => new(_haContext, "number.working_debounce_time");
    ///<summary>Working Tolerance</summary>
    public NumberEntity WorkingTolerance => new(_haContext, "number.working_tolerance");
    ///<summary>Working Transition Time</summary>
    public NumberEntity WorkingTransitionTime => new(_haContext, "number.working_transition_time");
}