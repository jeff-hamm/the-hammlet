//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.0334583-08:00
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
public partial record ConversationProcessParameters
{
    ///<summary>Transcribed text input. eg: Turn all lights on</summary>
    [JsonPropertyName("text")]
    public string? Text { get; init; }

    ///<summary>Language of text. Defaults to server language. eg: NL</summary>
    [JsonPropertyName("language")]
    public string? Language { get; init; }

    ///<summary>Conversation agent to process your request. The conversation agent is the brains of your assistant. It processes the incoming text commands. eg: homeassistant</summary>
    [JsonPropertyName("agent_id")]
    public object? AgentId { get; init; }

    ///<summary>ID of the conversation, to be able to continue a previous conversation eg: my_conversation_1</summary>
    [JsonPropertyName("conversation_id")]
    public string? ConversationId { get; init; }
}