//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T15:53:27.7516000-08:00
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
public enum SelectOptions
{
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("aggressive"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Aggressive,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("all"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    All,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("all off"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Alloff,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("bright"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Bright,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("brightness preset 1"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Brightnesspreset1,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("brightness preset 2"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Brightnesspreset2,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("brightness preset 3"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Brightnesspreset3,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("brightness preset 4"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Brightnesspreset4,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("brightness preset 5"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Brightnesspreset5,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("celsius"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Celsius,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("click"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Click,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("customized"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Customized,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("debug"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Debug,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("default"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Default,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("dinner time"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Dinnertime,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("direct"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Direct,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("error"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Error,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("evenink"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Evenink,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("fahrenheit"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Fahrenheit,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("hammlet cast"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Hammletcast,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("hangout"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Hangout,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("home assistant"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Homeassistant,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("info"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Info,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("initial"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Initial,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("jumpbox-nabu"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Jumpboxnabu,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("loading"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Loading,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("night"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Night,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("none"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    None,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("normal butts"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Normalbutts,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("not set"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Notset,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("off"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Off,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("ok-nabu"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Oknabu,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("on"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    On,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("one"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    One,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("pants emergency start off"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Pantsemergencystartoff,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("pants emergency start on"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Pantsemergencystarton,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("pants off emergency"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Pantsoffemergency,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("pink and sexy"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Pinkandsexy,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("playlist"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Playlist,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("playlist radio"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Playlistradio,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("preferred"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Preferred,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("previous"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Previous,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("random"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Random,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("relaxed"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Relaxed,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("shuffle"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Shuffle,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("shuffle random"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Shufflerandom,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("switch"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Switch,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("toggle"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Toggle,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("tv"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Tv,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("warning"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Warning,
    [System.Text.Json.Serialization.JsonStringEnumMemberNameAttribute("working"), System.Text.Json.Serialization.JsonConverter(typeof(SingleObjectAsArrayConverter<SelectOptions>))]
    Working
}