//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v24.50.0.0
//   At: 2024-12-14T14:51:18.4776839-08:00
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
public partial class EventEntities
{
    private readonly IHaContext _haContext;
    public EventEntities(IHaContext haContext)
    {
        _haContext = haContext;
    }

    /// <summary>Enumerates all event entities currently registered (at runtime) in Home Assistant as EventEntity</summary>
    public IEnumerable<EventEntity> EnumerateAll() => _haContext.GetAllEntities().Where(e => e.EntityId.StartsWith("event.")).Select(e => new EventEntity(e));
    ///<summary>Bedroom Dimmer</summary>
    public EventEntity BedroomDimmer => new(_haContext, "event.bedroom_dimmer");
    ///<summary>Hammlights Dimmer</summary>
    public EventEntity HammlightsDimmer => new(_haContext, "event.hammlights_dimmer");
    ///<summary>S2 Remote Control Switch Scene 001</summary>
    public EventEntity S2RemoteControlSwitchScene001 => new(_haContext, "event.s2_remote_control_switch_scene_001");
    ///<summary>S2 Remote Control Switch Scene 002</summary>
    public EventEntity S2RemoteControlSwitchScene002 => new(_haContext, "event.s2_remote_control_switch_scene_002");
    ///<summary>S2 Remote Control Switch Scene 003</summary>
    public EventEntity S2RemoteControlSwitchScene003 => new(_haContext, "event.s2_remote_control_switch_scene_003");
    ///<summary>S2 Remote Control Switch Scene 004</summary>
    public EventEntity S2RemoteControlSwitchScene004 => new(_haContext, "event.s2_remote_control_switch_scene_004");
    ///<summary>Wireless Switch 3241 Button</summary>
    public EventEntity WirelessSwitch3241Button => new(_haContext, "event.wireless_switch_3241_button");
    ///<summary>Wireless Switch 6105 Button</summary>
    public EventEntity WirelessSwitch6105Button => new(_haContext, "event.wireless_switch_6105_button");
}