//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.0685402-08:00
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
public partial class OpenplantbookEntities : IEntityDomain<OpenplantbookEntity>
{
    private readonly IHaContext _haContext;
    public OpenplantbookEntities(IHaContext haContext)
    {
        _haContext = haContext;
    }

    /// <summary>Enumerates all openplantbook entities currently registered (at runtime) in Home Assistant as OpenplantbookEntity</summary>
    public IEnumerable<OpenplantbookEntity> EnumerateAll() => _haContext.GetAllEntities().Where(e => e.EntityId.StartsWith("openplantbook.")).Select(e => new OpenplantbookEntity(e));
    public OpenplantbookEntity Entity(string entityId)
    {
        return (OpenplantbookEntity)_haContext.Entity(entityId);
    }

    public OpenplantbookEntity SearchResult => new(_haContext, "openplantbook.search_result");
    public OpenplantbookIds Ids => new();
}