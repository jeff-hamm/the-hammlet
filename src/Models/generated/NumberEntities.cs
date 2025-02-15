//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.0577574-08:00
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
public partial class NumberEntities : IEntityDomain<NumberEntity>
{
    private readonly IHaContext _haContext;
    public NumberEntities(IHaContext haContext)
    {
        _haContext = haContext;
    }

    /// <summary>Enumerates all number entities currently registered (at runtime) in Home Assistant as NumberEntity</summary>
    public IEnumerable<NumberEntity> EnumerateAll() => _haContext.GetAllEntities().Where(e => e.EntityId.StartsWith("number.")).Select(e => new NumberEntity(e));
    public NumberEntity Entity(string entityId)
    {
        return (NumberEntity)_haContext.Entity(entityId);
    }

    ///<summary>Alive Remote Indicator value</summary>
    public NumberEntity AliveRemoteIndicatorValue => new(_haContext, "number.alive_remote_indicator_value");
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
    ///<summary>Laser Monstera max air humidity</summary>
    public NumberEntity LaserMonsteraMaxAirHumidity => new(_haContext, "number.laser_monstera_max_air_humidity");
    ///<summary>Laser Monstera max conductivity</summary>
    public NumberEntity LaserMonsteraMaxConductivity => new(_haContext, "number.laser_monstera_max_conductivity");
    ///<summary>Laser Monstera max dli</summary>
    public NumberEntity LaserMonsteraMaxDli => new(_haContext, "number.laser_monstera_max_dli");
    ///<summary>Laser Monstera max illuminance</summary>
    public NumberEntity LaserMonsteraMaxIlluminance => new(_haContext, "number.laser_monstera_max_illuminance");
    ///<summary>Laser Monstera max soil moisture</summary>
    public NumberEntity LaserMonsteraMaxSoilMoisture => new(_haContext, "number.laser_monstera_max_soil_moisture");
    ///<summary>Laser Monstera max temperature</summary>
    public NumberEntity LaserMonsteraMaxTemperature => new(_haContext, "number.laser_monstera_max_temperature");
    ///<summary>Laser Monstera min air humidity</summary>
    public NumberEntity LaserMonsteraMinAirHumidity => new(_haContext, "number.laser_monstera_min_air_humidity");
    ///<summary>Laser Monstera min conductivity</summary>
    public NumberEntity LaserMonsteraMinConductivity => new(_haContext, "number.laser_monstera_min_conductivity");
    ///<summary>Laser Monstera min dli</summary>
    public NumberEntity LaserMonsteraMinDli => new(_haContext, "number.laser_monstera_min_dli");
    ///<summary>Laser Monstera min illuminance</summary>
    public NumberEntity LaserMonsteraMinIlluminance => new(_haContext, "number.laser_monstera_min_illuminance");
    ///<summary>Laser Monstera min soil moisture</summary>
    public NumberEntity LaserMonsteraMinSoilMoisture => new(_haContext, "number.laser_monstera_min_soil_moisture");
    ///<summary>Laser Monstera min temperature</summary>
    public NumberEntity LaserMonsteraMinTemperature => new(_haContext, "number.laser_monstera_min_temperature");
    ///<summary>Liminal Dimmer Brightness 0</summary>
    public NumberEntity LiminalDimmerBrightness => new(_haContext, "number.liminal_dimmer_brightness");
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
    ///<summary>Off transition time</summary>
    public NumberEntity SmartRgbtwBulbOffTransitionTime => new(_haContext, "number.smart_rgbtw_bulb_off_transition_time");
    ///<summary>Off transition time</summary>
    public NumberEntity SmartRgbtwBulbOffTransitionTime2 => new(_haContext, "number.smart_rgbtw_bulb_off_transition_time_2");
    ///<summary>Smart RGBTW Bulb Off transition time</summary>
    public NumberEntity SmartRgbtwBulbOffTransitionTime3 => new(_haContext, "number.smart_rgbtw_bulb_off_transition_time_3");
    ///<summary>On level</summary>
    public NumberEntity SmartRgbtwBulbOnLevel => new(_haContext, "number.smart_rgbtw_bulb_on_level");
    ///<summary>On level</summary>
    public NumberEntity SmartRgbtwBulbOnLevel2 => new(_haContext, "number.smart_rgbtw_bulb_on_level_2");
    ///<summary>Smart RGBTW Bulb On level</summary>
    public NumberEntity SmartRgbtwBulbOnLevel3 => new(_haContext, "number.smart_rgbtw_bulb_on_level_3");
    ///<summary>On/Off transition time</summary>
    public NumberEntity SmartRgbtwBulbOnOffTransitionTime => new(_haContext, "number.smart_rgbtw_bulb_on_off_transition_time");
    ///<summary>On/Off transition time</summary>
    public NumberEntity SmartRgbtwBulbOnOffTransitionTime2 => new(_haContext, "number.smart_rgbtw_bulb_on_off_transition_time_2");
    ///<summary>Smart RGBTW Bulb On/Off transition time</summary>
    public NumberEntity SmartRgbtwBulbOnOffTransitionTime3 => new(_haContext, "number.smart_rgbtw_bulb_on_off_transition_time_3");
    ///<summary>On transition time</summary>
    public NumberEntity SmartRgbtwBulbOnTransitionTime => new(_haContext, "number.smart_rgbtw_bulb_on_transition_time");
    ///<summary>On transition time</summary>
    public NumberEntity SmartRgbtwBulbOnTransitionTime2 => new(_haContext, "number.smart_rgbtw_bulb_on_transition_time_2");
    ///<summary>Smart RGBTW Bulb On transition time</summary>
    public NumberEntity SmartRgbtwBulbOnTransitionTime3 => new(_haContext, "number.smart_rgbtw_bulb_on_transition_time_3");
    ///<summary>Off transition time</summary>
    public NumberEntity SmartWiFiLampDimmerOffTransitionTime => new(_haContext, "number.smart_wi_fi_lamp_dimmer_off_transition_time");
    ///<summary>Off transition time</summary>
    public NumberEntity SmartWiFiLampDimmerOffTransitionTime2 => new(_haContext, "number.smart_wi_fi_lamp_dimmer_off_transition_time_2");
    ///<summary>Smart Wi-Fi Lamp Dimmer Off transition time</summary>
    public NumberEntity SmartWiFiLampDimmerOffTransitionTime3 => new(_haContext, "number.smart_wi_fi_lamp_dimmer_off_transition_time_3");
    ///<summary>On level</summary>
    public NumberEntity SmartWiFiLampDimmerOnLevel => new(_haContext, "number.smart_wi_fi_lamp_dimmer_on_level");
    ///<summary>On level</summary>
    public NumberEntity SmartWiFiLampDimmerOnLevel2 => new(_haContext, "number.smart_wi_fi_lamp_dimmer_on_level_2");
    ///<summary>Smart Wi-Fi Lamp Dimmer On level</summary>
    public NumberEntity SmartWiFiLampDimmerOnLevel3 => new(_haContext, "number.smart_wi_fi_lamp_dimmer_on_level_3");
    ///<summary>On transition time</summary>
    public NumberEntity SmartWiFiLampDimmerOnTransitionTime => new(_haContext, "number.smart_wi_fi_lamp_dimmer_on_transition_time");
    ///<summary>On transition time</summary>
    public NumberEntity SmartWiFiLampDimmerOnTransitionTime2 => new(_haContext, "number.smart_wi_fi_lamp_dimmer_on_transition_time_2");
    ///<summary>Smart Wi-Fi Lamp Dimmer On transition time</summary>
    public NumberEntity SmartWiFiLampDimmerOnTransitionTime3 => new(_haContext, "number.smart_wi_fi_lamp_dimmer_on_transition_time_3");
    ///<summary>Succulent Arrangement max air humidity</summary>
    public NumberEntity SucculentArrangementMaxAirHumidity => new(_haContext, "number.succulent_arrangement_max_air_humidity");
    ///<summary>Succulent Arrangement max conductivity</summary>
    public NumberEntity SucculentArrangementMaxConductivity => new(_haContext, "number.succulent_arrangement_max_conductivity");
    ///<summary>Succulent Arrangement max dli</summary>
    public NumberEntity SucculentArrangementMaxDli => new(_haContext, "number.succulent_arrangement_max_dli");
    ///<summary>Succulent Arrangement max illuminance</summary>
    public NumberEntity SucculentArrangementMaxIlluminance => new(_haContext, "number.succulent_arrangement_max_illuminance");
    ///<summary>Succulent Arrangement max soil moisture</summary>
    public NumberEntity SucculentArrangementMaxSoilMoisture => new(_haContext, "number.succulent_arrangement_max_soil_moisture");
    ///<summary>Succulent Arrangement max temperature</summary>
    public NumberEntity SucculentArrangementMaxTemperature => new(_haContext, "number.succulent_arrangement_max_temperature");
    ///<summary>Succulent Arrangement min air humidity</summary>
    public NumberEntity SucculentArrangementMinAirHumidity => new(_haContext, "number.succulent_arrangement_min_air_humidity");
    ///<summary>Succulent Arrangement min conductivity</summary>
    public NumberEntity SucculentArrangementMinConductivity => new(_haContext, "number.succulent_arrangement_min_conductivity");
    ///<summary>Succulent Arrangement min dli</summary>
    public NumberEntity SucculentArrangementMinDli => new(_haContext, "number.succulent_arrangement_min_dli");
    ///<summary>Succulent Arrangement min illuminance</summary>
    public NumberEntity SucculentArrangementMinIlluminance => new(_haContext, "number.succulent_arrangement_min_illuminance");
    ///<summary>Succulent Arrangement min soil moisture</summary>
    public NumberEntity SucculentArrangementMinSoilMoisture => new(_haContext, "number.succulent_arrangement_min_soil_moisture");
    ///<summary>Succulent Arrangement min temperature</summary>
    public NumberEntity SucculentArrangementMinTemperature => new(_haContext, "number.succulent_arrangement_min_temperature");
    ///<summary>Tentacle Lamp Smooth off</summary>
    public NumberEntity TentacleLampSmoothOff => new(_haContext, "number.tentacle_lamp_smooth_off");
    ///<summary>Tentacle Lamp Smooth on</summary>
    public NumberEntity TentacleLampSmoothOn => new(_haContext, "number.tentacle_lamp_smooth_on");
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
    public NumberIds Ids => new();
}