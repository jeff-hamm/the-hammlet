//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:13.9891645-08:00
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
public partial class AlarmControlPanelServices
{
    private readonly IHaContext _haContext;
    public AlarmControlPanelServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Sets the alarm to: _armed, no one home_.</summary>
    ///<param name="target">The target for this service call</param>
    public void AlarmArmAway(ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data)
    {
        _haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
    }

    ///<summary>Sets the alarm to: _armed, no one home_.</summary>
    ///<param name="code">Code to arm the alarm. eg: 1234</param>
    public void AlarmArmAway(ServiceTarget target, string? code = null)
    {
        _haContext.CallService("alarm_control_panel", "alarm_arm_away", target, new AlarmControlPanelAlarmArmAwayParameters { Code = code });
    }

    ///<summary>Arms the alarm while allowing to bypass a custom area.</summary>
    ///<param name="target">The target for this service call</param>
    public void AlarmArmCustomBypass(ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data)
    {
        _haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
    }

    ///<summary>Arms the alarm while allowing to bypass a custom area.</summary>
    ///<param name="code">Code to arm the alarm. eg: 1234</param>
    public void AlarmArmCustomBypass(ServiceTarget target, string? code = null)
    {
        _haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, new AlarmControlPanelAlarmArmCustomBypassParameters { Code = code });
    }

    ///<summary>Sets the alarm to: _armed, but someone is home_.</summary>
    ///<param name="target">The target for this service call</param>
    public void AlarmArmHome(ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data)
    {
        _haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
    }

    ///<summary>Sets the alarm to: _armed, but someone is home_.</summary>
    ///<param name="code">Code to arm the alarm. eg: 1234</param>
    public void AlarmArmHome(ServiceTarget target, string? code = null)
    {
        _haContext.CallService("alarm_control_panel", "alarm_arm_home", target, new AlarmControlPanelAlarmArmHomeParameters { Code = code });
    }

    ///<summary>Sets the alarm to: _armed for the night_.</summary>
    ///<param name="target">The target for this service call</param>
    public void AlarmArmNight(ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data)
    {
        _haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
    }

    ///<summary>Sets the alarm to: _armed for the night_.</summary>
    ///<param name="code">Code to arm the alarm. eg: 1234</param>
    public void AlarmArmNight(ServiceTarget target, string? code = null)
    {
        _haContext.CallService("alarm_control_panel", "alarm_arm_night", target, new AlarmControlPanelAlarmArmNightParameters { Code = code });
    }

    ///<summary>Sets the alarm to: _armed for vacation_.</summary>
    ///<param name="target">The target for this service call</param>
    public void AlarmArmVacation(ServiceTarget target, AlarmControlPanelAlarmArmVacationParameters data)
    {
        _haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, data);
    }

    ///<summary>Sets the alarm to: _armed for vacation_.</summary>
    ///<param name="code">Code to arm the alarm. eg: 1234</param>
    public void AlarmArmVacation(ServiceTarget target, string? code = null)
    {
        _haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, new AlarmControlPanelAlarmArmVacationParameters { Code = code });
    }

    ///<summary>Disarms the alarm.</summary>
    ///<param name="target">The target for this service call</param>
    public void AlarmDisarm(ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data)
    {
        _haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
    }

    ///<summary>Disarms the alarm.</summary>
    ///<param name="code">Code to disarm the alarm. eg: 1234</param>
    public void AlarmDisarm(ServiceTarget target, string? code = null)
    {
        _haContext.CallService("alarm_control_panel", "alarm_disarm", target, new AlarmControlPanelAlarmDisarmParameters { Code = code });
    }

    ///<summary>Trigger the alarm manually.</summary>
    ///<param name="target">The target for this service call</param>
    public void AlarmTrigger(ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data)
    {
        _haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
    }

    ///<summary>Trigger the alarm manually.</summary>
    ///<param name="code">Code to arm the alarm. eg: 1234</param>
    public void AlarmTrigger(ServiceTarget target, string? code = null)
    {
        _haContext.CallService("alarm_control_panel", "alarm_trigger", target, new AlarmControlPanelAlarmTriggerParameters { Code = code });
    }
}