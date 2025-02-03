//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.0621532-08:00
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
public partial class GroupServices
{
    private readonly IHaContext _haContext;
    public GroupServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Reloads group configuration, entities, and notify services from YAML-configuration.</summary>
    public void Reload(object? data = null)
    {
        _haContext.CallService("group", "reload", null, data);
    }

    ///<summary>Removes a group.</summary>
    public void Remove(GroupRemoveParameters data)
    {
        _haContext.CallService("group", "remove", null, data);
    }

    ///<summary>Removes a group.</summary>
    ///<param name="objectId">Object ID of this group. This object ID is used as part of the entity ID. Entity ID format: [domain].[object_id]. eg: test_group</param>
    public void Remove(object objectId)
    {
        _haContext.CallService("group", "remove", null, new GroupRemoveParameters { ObjectId = objectId });
    }

    ///<summary>Creates/Updates a group.</summary>
    public void Set(GroupSetParameters data)
    {
        _haContext.CallService("group", "set", null, data);
    }

    ///<summary>Creates/Updates a group.</summary>
    ///<param name="objectId">Object ID of this group. This object ID is used as part of the entity ID. Entity ID format: [domain].[object_id]. eg: test_group</param>
    ///<param name="name">Name of the group. eg: My test group</param>
    ///<param name="icon">Name of the icon for the group. eg: mdi:camera</param>
    ///<param name="entities">List of all members in the group. Cannot be used in combination with `Add entities` or `Remove entities`. eg: domain.entity_id1, domain.entity_id2</param>
    ///<param name="addEntities">List of members to be added to the group. Cannot be used in combination with `Entities` or `Remove entities`. eg: domain.entity_id1, domain.entity_id2</param>
    ///<param name="removeEntities">List of members to be removed from a group. Cannot be used in combination with `Entities` or `Add entities`. eg: domain.entity_id1, domain.entity_id2</param>
    ///<param name="all">Enable this option if the group should only be used when all entities are in state `on`.</param>
    public void Set(string objectId, string? name = null, object? icon = null, IEnumerable<string>? entities = null, IEnumerable<string>? addEntities = null, IEnumerable<string>? removeEntities = null, bool? all = null)
    {
        _haContext.CallService("group", "set", null, new GroupSetParameters { ObjectId = objectId, Name = name, Icon = icon, Entities = entities, AddEntities = addEntities, RemoveEntities = removeEntities, All = all });
    }
}