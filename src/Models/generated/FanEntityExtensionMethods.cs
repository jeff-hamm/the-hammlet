//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.4863364-08:00
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
public static class FanEntityExtensionMethods
{
    ///<summary>Decreases the speed of a fan.</summary>
    public static void DecreaseSpeed(this FanEntity target, FanDecreaseSpeedParameters data)
    {
        target.CallService("decrease_speed", data);
    }

    ///<summary>Decreases the speed of a fan.</summary>
    public static void DecreaseSpeed(this IEnumerable<FanEntity> target, FanDecreaseSpeedParameters data)
    {
        target.CallService("decrease_speed", data);
    }

    ///<summary>Decreases the speed of a fan.</summary>
    ///<param name="target">The FanEntity to call this service for</param>
    ///<param name="percentageStep">Percentage step by which the speed should be decreased.</param>
    public static void DecreaseSpeed(this FanEntity target, double? percentageStep = null)
    {
        target.CallService("decrease_speed", new FanDecreaseSpeedParameters { PercentageStep = percentageStep });
    }

    ///<summary>Decreases the speed of a fan.</summary>
    ///<param name="target">The IEnumerable&lt;FanEntity&gt; to call this service for</param>
    ///<param name="percentageStep">Percentage step by which the speed should be decreased.</param>
    public static void DecreaseSpeed(this IEnumerable<FanEntity> target, double? percentageStep = null)
    {
        target.CallService("decrease_speed", new FanDecreaseSpeedParameters { PercentageStep = percentageStep });
    }

    ///<summary>Increases the speed of a fan.</summary>
    public static void IncreaseSpeed(this FanEntity target, FanIncreaseSpeedParameters data)
    {
        target.CallService("increase_speed", data);
    }

    ///<summary>Increases the speed of a fan.</summary>
    public static void IncreaseSpeed(this IEnumerable<FanEntity> target, FanIncreaseSpeedParameters data)
    {
        target.CallService("increase_speed", data);
    }

    ///<summary>Increases the speed of a fan.</summary>
    ///<param name="target">The FanEntity to call this service for</param>
    ///<param name="percentageStep">Percentage step by which the speed should be increased.</param>
    public static void IncreaseSpeed(this FanEntity target, double? percentageStep = null)
    {
        target.CallService("increase_speed", new FanIncreaseSpeedParameters { PercentageStep = percentageStep });
    }

    ///<summary>Increases the speed of a fan.</summary>
    ///<param name="target">The IEnumerable&lt;FanEntity&gt; to call this service for</param>
    ///<param name="percentageStep">Percentage step by which the speed should be increased.</param>
    public static void IncreaseSpeed(this IEnumerable<FanEntity> target, double? percentageStep = null)
    {
        target.CallService("increase_speed", new FanIncreaseSpeedParameters { PercentageStep = percentageStep });
    }

    ///<summary>Controls the oscillation of a fan.</summary>
    public static void Oscillate(this FanEntity target, FanOscillateParameters data)
    {
        target.CallService("oscillate", data);
    }

    ///<summary>Controls the oscillation of a fan.</summary>
    public static void Oscillate(this IEnumerable<FanEntity> target, FanOscillateParameters data)
    {
        target.CallService("oscillate", data);
    }

    ///<summary>Controls the oscillation of a fan.</summary>
    ///<param name="target">The FanEntity to call this service for</param>
    ///<param name="oscillating">Turns oscillation on/off.</param>
    public static void Oscillate(this FanEntity target, bool oscillating)
    {
        target.CallService("oscillate", new FanOscillateParameters { Oscillating = oscillating });
    }

    ///<summary>Controls the oscillation of a fan.</summary>
    ///<param name="target">The IEnumerable&lt;FanEntity&gt; to call this service for</param>
    ///<param name="oscillating">Turns oscillation on/off.</param>
    public static void Oscillate(this IEnumerable<FanEntity> target, bool oscillating)
    {
        target.CallService("oscillate", new FanOscillateParameters { Oscillating = oscillating });
    }

    ///<summary>Sets a fan&apos;s rotation direction.</summary>
    public static void SetDirection(this FanEntity target, FanSetDirectionParameters data)
    {
        target.CallService("set_direction", data);
    }

    ///<summary>Sets a fan&apos;s rotation direction.</summary>
    public static void SetDirection(this IEnumerable<FanEntity> target, FanSetDirectionParameters data)
    {
        target.CallService("set_direction", data);
    }

    ///<summary>Sets a fan&apos;s rotation direction.</summary>
    ///<param name="target">The FanEntity to call this service for</param>
    ///<param name="direction">Direction of the fan rotation.</param>
    public static void SetDirection(this FanEntity target, object direction)
    {
        target.CallService("set_direction", new FanSetDirectionParameters { Direction = direction });
    }

    ///<summary>Sets a fan&apos;s rotation direction.</summary>
    ///<param name="target">The IEnumerable&lt;FanEntity&gt; to call this service for</param>
    ///<param name="direction">Direction of the fan rotation.</param>
    public static void SetDirection(this IEnumerable<FanEntity> target, object direction)
    {
        target.CallService("set_direction", new FanSetDirectionParameters { Direction = direction });
    }

    ///<summary>Sets the speed of a fan.</summary>
    public static void SetPercentage(this FanEntity target, FanSetPercentageParameters data)
    {
        target.CallService("set_percentage", data);
    }

    ///<summary>Sets the speed of a fan.</summary>
    public static void SetPercentage(this IEnumerable<FanEntity> target, FanSetPercentageParameters data)
    {
        target.CallService("set_percentage", data);
    }

    ///<summary>Sets the speed of a fan.</summary>
    ///<param name="target">The FanEntity to call this service for</param>
    ///<param name="percentage">Speed of the fan.</param>
    public static void SetPercentage(this FanEntity target, double percentage)
    {
        target.CallService("set_percentage", new FanSetPercentageParameters { Percentage = percentage });
    }

    ///<summary>Sets the speed of a fan.</summary>
    ///<param name="target">The IEnumerable&lt;FanEntity&gt; to call this service for</param>
    ///<param name="percentage">Speed of the fan.</param>
    public static void SetPercentage(this IEnumerable<FanEntity> target, double percentage)
    {
        target.CallService("set_percentage", new FanSetPercentageParameters { Percentage = percentage });
    }

    ///<summary>Sets preset fan mode.</summary>
    public static void SetPresetMode(this FanEntity target, FanSetPresetModeParameters data)
    {
        target.CallService("set_preset_mode", data);
    }

    ///<summary>Sets preset fan mode.</summary>
    public static void SetPresetMode(this IEnumerable<FanEntity> target, FanSetPresetModeParameters data)
    {
        target.CallService("set_preset_mode", data);
    }

    ///<summary>Sets preset fan mode.</summary>
    ///<param name="target">The FanEntity to call this service for</param>
    ///<param name="presetMode">Preset fan mode. eg: auto</param>
    public static void SetPresetMode(this FanEntity target, string presetMode)
    {
        target.CallService("set_preset_mode", new FanSetPresetModeParameters { PresetMode = presetMode });
    }

    ///<summary>Sets preset fan mode.</summary>
    ///<param name="target">The IEnumerable&lt;FanEntity&gt; to call this service for</param>
    ///<param name="presetMode">Preset fan mode. eg: auto</param>
    public static void SetPresetMode(this IEnumerable<FanEntity> target, string presetMode)
    {
        target.CallService("set_preset_mode", new FanSetPresetModeParameters { PresetMode = presetMode });
    }

    ///<summary>Toggles a fan on/off.</summary>
    public static void Toggle(this FanEntity target, object? data = null)
    {
        target.CallService("toggle", data);
    }

    ///<summary>Toggles a fan on/off.</summary>
    public static void Toggle(this IEnumerable<FanEntity> target, object? data = null)
    {
        target.CallService("toggle", data);
    }

    ///<summary>Turns fan off.</summary>
    public static void TurnOff(this FanEntity target, object? data = null)
    {
        target.CallService("turn_off", data);
    }

    ///<summary>Turns fan off.</summary>
    public static void TurnOff(this IEnumerable<FanEntity> target, object? data = null)
    {
        target.CallService("turn_off", data);
    }

    ///<summary>Turns fan on.</summary>
    public static void TurnOn(this FanEntity target, FanTurnOnParameters data)
    {
        target.CallService("turn_on", data);
    }

    ///<summary>Turns fan on.</summary>
    public static void TurnOn(this IEnumerable<FanEntity> target, FanTurnOnParameters data)
    {
        target.CallService("turn_on", data);
    }

    ///<summary>Turns fan on.</summary>
    ///<param name="target">The FanEntity to call this service for</param>
    ///<param name="percentage">Speed of the fan.</param>
    ///<param name="presetMode">Preset fan mode. eg: auto</param>
    public static void TurnOn(this FanEntity target, double? percentage = null, string? presetMode = null)
    {
        target.CallService("turn_on", new FanTurnOnParameters { Percentage = percentage, PresetMode = presetMode });
    }

    ///<summary>Turns fan on.</summary>
    ///<param name="target">The IEnumerable&lt;FanEntity&gt; to call this service for</param>
    ///<param name="percentage">Speed of the fan.</param>
    ///<param name="presetMode">Preset fan mode. eg: auto</param>
    public static void TurnOn(this IEnumerable<FanEntity> target, double? percentage = null, string? presetMode = null)
    {
        target.CallService("turn_on", new FanTurnOnParameters { Percentage = percentage, PresetMode = presetMode });
    }
}