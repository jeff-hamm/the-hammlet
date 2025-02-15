//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.0816564-08:00
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
public partial class ScriptEntities : IEntityDomain<ScriptEntity>
{
    private readonly IHaContext _haContext;
    public ScriptEntities(IHaContext haContext)
    {
        _haContext = haContext;
    }

    /// <summary>Enumerates all script entities currently registered (at runtime) in Home Assistant as ScriptEntity</summary>
    public IEnumerable<ScriptEntity> EnumerateAll() => _haContext.GetAllEntities().Where(e => e.EntityId.StartsWith("script.")).Select(e => new ScriptEntity(e));
    public ScriptEntity Entity(string entityId)
    {
        return (ScriptEntity)_haContext.Entity(entityId);
    }

    ///<summary>toggle_input</summary>
    public ScriptEntity ToggleInput => new(_haContext, "script.toggle_input");
    ///<summary>Toggle Mute</summary>
    public ScriptEntity ToggleMute => new(_haContext, "script.toggle_mute");
    public ScriptIds Ids => new();
}