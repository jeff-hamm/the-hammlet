//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.0315256-08:00
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
public partial class ConversationServices
{
    private readonly IHaContext _haContext;
    public ConversationServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Launches a conversation from a transcribed text.</summary>
    public void Process(ConversationProcessParameters data)
    {
        _haContext.CallService("conversation", "process", null, data);
    }

    ///<summary>Launches a conversation from a transcribed text.</summary>
    ///<param name="text">Transcribed text input. eg: Turn all lights on</param>
    ///<param name="language">Language of text. Defaults to server language. eg: NL</param>
    ///<param name="agentId">Conversation agent to process your request. The conversation agent is the brains of your assistant. It processes the incoming text commands. eg: homeassistant</param>
    ///<param name="conversationId">ID of the conversation, to be able to continue a previous conversation eg: my_conversation_1</param>
    public void Process(string text, string? language = null, object? agentId = null, string? conversationId = null)
    {
        _haContext.CallService("conversation", "process", null, new ConversationProcessParameters { Text = text, Language = language, AgentId = agentId, ConversationId = conversationId });
    }

    ///<summary>Launches a conversation from a transcribed text.</summary>
    public Task<JsonElement?> ProcessAsync(ConversationProcessParameters data)
    {
        return _haContext.CallServiceWithResponseAsync("conversation", "process", null, data);
    }

    ///<summary>Launches a conversation from a transcribed text.</summary>
    ///<param name="text">Transcribed text input. eg: Turn all lights on</param>
    ///<param name="language">Language of text. Defaults to server language. eg: NL</param>
    ///<param name="agentId">Conversation agent to process your request. The conversation agent is the brains of your assistant. It processes the incoming text commands. eg: homeassistant</param>
    ///<param name="conversationId">ID of the conversation, to be able to continue a previous conversation eg: my_conversation_1</param>
    public Task<JsonElement?> ProcessAsync(string text, string? language = null, object? agentId = null, string? conversationId = null)
    {
        return _haContext.CallServiceWithResponseAsync("conversation", "process", null, new ConversationProcessParameters { Text = text, Language = language, AgentId = agentId, ConversationId = conversationId });
    }

    ///<summary>Reloads the intent configuration.</summary>
    public void Reload(ConversationReloadParameters data)
    {
        _haContext.CallService("conversation", "reload", null, data);
    }

    ///<summary>Reloads the intent configuration.</summary>
    ///<param name="language">Language to clear cached intents for. Defaults to server language. eg: NL</param>
    ///<param name="agentId">Conversation agent to reload. eg: homeassistant</param>
    public void Reload(string? language = null, object? agentId = null)
    {
        _haContext.CallService("conversation", "reload", null, new ConversationReloadParameters { Language = language, AgentId = agentId });
    }
}