//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:13.6963637-08:00
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
/// <summary>
/// Allows HassModel to instantiate the correct generated Entity types
/// </summary>
public class GeneratedEntityFactory : IEntityFactory
{
    public virtual Entity CreateEntity(IHaContext haContext, string entityId)
    {
        var dot = entityId.IndexOf('.', StringComparison.Ordinal);
        var domain = dot < 0 ? entityId.AsSpan() : entityId[..dot];
        return domain switch
        {
            "assist_satellite" => new AssistSatelliteEntity(haContext, entityId),
            "automation" => new AutomationEntity(haContext, entityId),
            "binary_sensor" => new BinarySensorEntity(haContext, entityId),
            "button" => new ButtonEntity(haContext, entityId),
            "calendar" => new CalendarEntity(haContext, entityId),
            "conversation" => new ConversationEntity(haContext, entityId),
            "device_tracker" => new DeviceTrackerEntity(haContext, entityId),
            "event" => new EventEntity(haContext, entityId),
            "fan" => new FanEntity(haContext, entityId),
            "input_boolean" => new InputBooleanEntity(haContext, entityId),
            "input_number" => new InputNumberEntity(haContext, entityId),
            "input_select" => new InputSelectEntity(haContext, entityId),
            "light" => new LightEntity(haContext, entityId),
            "media_player" => new MediaPlayerEntity(haContext, entityId),
            "number" => new NumberEntity(haContext, entityId),
            "openplantbook" => new OpenplantbookEntity(haContext, entityId),
            "person" => new PersonEntity(haContext, entityId),
            "plant" => new PlantEntity(haContext, entityId),
            "remote" => new RemoteEntity(haContext, entityId),
            "scene" => new SceneEntity(haContext, entityId),
            "script" => new ScriptEntity(haContext, entityId),
            "select" => new SelectEntity(haContext, entityId),
            "sensor" when IsNumeric() => new NumericSensorEntity(haContext, entityId),
            "sensor" => new SensorEntity(haContext, entityId),
            "stt" => new SttEntity(haContext, entityId),
            "sun" => new SunEntity(haContext, entityId),
            "switch" => new SwitchEntity(haContext, entityId),
            "timer" => new TimerEntity(haContext, entityId),
            "todo" => new TodoEntity(haContext, entityId),
            "tts" => new TtsEntity(haContext, entityId),
            "update" => new UpdateEntity(haContext, entityId),
            "wake_word" => new WakeWordEntity(haContext, entityId),
            "weather" => new WeatherEntity(haContext, entityId),
            "zone" => new ZoneEntity(haContext, entityId),
            _ => new Entity(haContext, entityId)};
        bool IsNumeric() => haContext.GetState(entityId)?.AttributesJson?.TryGetProperty("unit_of_measurement", out _) ?? false;
    }
}