//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.1619661-08:00
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
public enum LightEffectList
{
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("addressable flicker")]
    Addressableflicker,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("alarm")]
    Alarm,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("candle flicker")]
    Candleflicker,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("christmas")]
    Christmas,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("color wipe")]
    Colorwipe,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("date night")]
    Datenight,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("disco")]
    Disco,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("facebook")]
    Facebook,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("fast random loop")]
    Fastrandomloop,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("fireworks")]
    Fireworks,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("happy birthday")]
    Happybirthday,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("home")]
    Home,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("lsd")]
    Lsd,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("movie")]
    Movie,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("night mode")]
    Nightmode,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("none")]
    None,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("police")]
    Police,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("police2")]
    Police2,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("pulse")]
    Pulse,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("random loop")]
    Randomloop,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("random twinkle")]
    Randomtwinkle,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("rgb")]
    Rgb,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("romance")]
    Romance,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("slow temp")]
    Slowtemp,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("slowdown")]
    Slowdown,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("stop")]
    Stop,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("strobe color")]
    Strobecolor,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("strobe epilepsy!")]
    Strobeepilepsy,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("sunrise")]
    Sunrise,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("sunset")]
    Sunset,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("tea time")]
    Teatime,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("twinkle")]
    Twinkle,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("twitter")]
    Twitter,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("whatsapp")]
    Whatsapp
}