//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.1940791-08:00
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
[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
public enum EventEventTypes
{
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("double_press")]
    DoublePress,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("easter_egg_press")]
    EasterEggPress,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("keyhelddown")]
    Keyhelddown,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("keypressed")]
    Keypressed,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("keypressed2x")]
    Keypressed2x,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("keypressed3x")]
    Keypressed3x,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("keyreleased")]
    Keyreleased,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("l")]
    L,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("long_press")]
    LongPress,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("ls")]
    Ls,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("press")]
    Press,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("rotate_left")]
    RotateLeft,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("rotate_left_pressed")]
    RotateLeftPressed,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("rotate_right")]
    RotateRight,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("rotate_right_pressed")]
    RotateRightPressed,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("s")]
    S,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("sl")]
    Sl,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("ss")]
    Ss,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("sss")]
    Sss,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("triple_press")]
    TriplePress
}