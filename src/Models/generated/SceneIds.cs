//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T15:53:27.5817714-08:00
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
public class SceneIds
{
    public string AllOff { get; } = "scene.all_off";
    public string Bright { get; } = "scene.bright";
    public string DinnerTime { get; } = "scene.dinner_time";
    public string Evenink { get; } = "scene.evenink";
    public string Hangout { get; } = "scene.hangout";
    public string Night { get; } = "scene.night";
    public string PinkAndSexy { get; } = "scene.pink_and_sexy";
    public string TurnOffAllLights { get; } = "scene.turn_off_all_lights";
    public string Working { get; } = "scene.working";
}