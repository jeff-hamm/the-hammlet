//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T15:53:27.8892633-08:00
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
public partial class GoogleAssistantServices
{
    private readonly IHaContext _haContext;
    public GoogleAssistantServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Sends a request_sync command to Google.</summary>
    public void RequestSync(GoogleAssistantRequestSyncParameters data)
    {
        _haContext.CallService("google_assistant", "request_sync", null, data);
    }

    ///<summary>Sends a request_sync command to Google.</summary>
    ///<param name="agentUserId">Only needed for automations. Specific Home Assistant user ID (not username, ID in Settings &gt; People &gt; Users &gt; under username) to sync with Google Assistant. Not needed when you use this action through Home Assistant frontend or API. Used in automation, script or other place where context.user_id is missing.</param>
    public void RequestSync(string? agentUserId = null)
    {
        _haContext.CallService("google_assistant", "request_sync", null, new GoogleAssistantRequestSyncParameters { AgentUserId = agentUserId });
    }
}