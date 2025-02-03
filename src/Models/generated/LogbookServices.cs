//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.1313111-08:00
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
public partial class LogbookServices
{
    private readonly IHaContext _haContext;
    public LogbookServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Creates a custom entry in the logbook.</summary>
    public void Log(LogbookLogParameters data)
    {
        _haContext.CallService("logbook", "log", null, data);
    }

    ///<summary>Creates a custom entry in the logbook.</summary>
    ///<param name="name">Custom name for an entity, can be referenced using an `entity_id`. eg: Kitchen</param>
    ///<param name="message">Message of the logbook entry. eg: is being used</param>
    ///<param name="entityId">Entity to reference in the logbook entry.</param>
    ///<param name="domain">Determines which icon is used in the logbook entry. The icon illustrates the integration domain related to this logbook entry. eg: light</param>
    public void Log(string name, string message, string? entityId = null, string? domain = null)
    {
        _haContext.CallService("logbook", "log", null, new LogbookLogParameters { Name = name, Message = message, EntityId = entityId, Domain = domain });
    }
}