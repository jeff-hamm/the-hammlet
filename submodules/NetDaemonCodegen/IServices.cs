//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-14T18:42:13.0049141-08:00
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

namespace HomeAssistantGenerated;
public interface IServices
{
    AlarmControlPanelServices AlarmControlPanel { get; }

    AutomationServices Automation { get; }

    BackupServices Backup { get; }

    ButtonServices Button { get; }

    CameraServices Camera { get; }

    CastServices Cast { get; }

    ClimateServices Climate { get; }

    CloudServices Cloud { get; }

    CloudflareServices Cloudflare { get; }

    ConversationServices Conversation { get; }

    CounterServices Counter { get; }

    CoverServices Cover { get; }

    FanServices Fan { get; }

    FfmpegServices Ffmpeg { get; }

    FluxLedServices FluxLed { get; }

    FrontendServices Frontend { get; }

    GroupServices Group { get; }

    HassioServices Hassio { get; }

    HomeassistantServices Homeassistant { get; }

    HumidifierServices Humidifier { get; }

    InputBooleanServices InputBoolean { get; }

    InputButtonServices InputButton { get; }

    InputDatetimeServices InputDatetime { get; }

    InputNumberServices InputNumber { get; }

    InputSelectServices InputSelect { get; }

    InputTextServices InputText { get; }

    LightServices Light { get; }

    LockServices Lock { get; }

    LogbookServices Logbook { get; }

    LoggerServices Logger { get; }

    MediaPlayerServices MediaPlayer { get; }

    MqttServices Mqtt { get; }

    NotifyServices Notify { get; }

    NumberServices Number { get; }

    PersistentNotificationServices PersistentNotification { get; }

    PersonServices Person { get; }

    PythonScriptServices PythonScript { get; }

    RecorderServices Recorder { get; }

    SceneServices Scene { get; }

    ScheduleServices Schedule { get; }

    ScriptServices Script { get; }

    SelectServices Select { get; }

    ShoppingListServices ShoppingList { get; }

    SirenServices Siren { get; }

    SwitchServices Switch { get; }

    SystemLogServices SystemLog { get; }

    TextServices Text { get; }

    TimerServices Timer { get; }

    TodoServices Todo { get; }

    TtsServices Tts { get; }

    UpdateServices Update { get; }

    VacuumServices Vacuum { get; }

    ValveServices Valve { get; }

    WeatherServices Weather { get; }

    ZoneServices Zone { get; }
}