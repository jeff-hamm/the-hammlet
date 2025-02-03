//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.1530720-08:00
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
public partial class NetdaemonServices
{
    private readonly IHaContext _haContext;
    public NetdaemonServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Create an entity</summary>
    public void EntityCreate(NetdaemonEntityCreateParameters data)
    {
        _haContext.CallService("netdaemon", "entity_create", null, data);
    }

    ///<summary>Create an entity</summary>
    ///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
    ///<param name="state">The state of the entity eg: Lorem ipsum</param>
    ///<param name="icon">The icon for the entity eg: mdi:rocket-launch-outline</param>
    ///<param name="unit">The unit of measurement for the entity</param>
    ///<param name="options">List of options for a select entity</param>
    ///<param name="attributes">The attributes of the entity</param>
    public void EntityCreate(object? entityId = null, object? state = null, object? icon = null, object? unit = null, object? options = null, object? attributes = null)
    {
        _haContext.CallService("netdaemon", "entity_create", null, new NetdaemonEntityCreateParameters { EntityId = entityId, State = state, Icon = icon, Unit = unit, Options = options, Attributes = attributes });
    }

    ///<summary>Remove an entity</summary>
    public void EntityRemove(NetdaemonEntityRemoveParameters data)
    {
        _haContext.CallService("netdaemon", "entity_remove", null, data);
    }

    ///<summary>Remove an entity</summary>
    ///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
    public void EntityRemove(object? entityId = null)
    {
        _haContext.CallService("netdaemon", "entity_remove", null, new NetdaemonEntityRemoveParameters { EntityId = entityId });
    }

    ///<summary>Update an entity</summary>
    public void EntityUpdate(NetdaemonEntityUpdateParameters data)
    {
        _haContext.CallService("netdaemon", "entity_update", null, data);
    }

    ///<summary>Update an entity</summary>
    ///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
    ///<param name="state">The state of the entity eg: Lorem ipsum</param>
    ///<param name="icon">The icon for the entity eg: mdi:rocket-launch-outline</param>
    ///<param name="unit">The unit of measurement for the entity</param>
    ///<param name="options">List of options for a select entity</param>
    ///<param name="attributes">The attributes of the entity</param>
    public void EntityUpdate(object? entityId = null, object? state = null, object? icon = null, object? unit = null, object? options = null, object? attributes = null)
    {
        _haContext.CallService("netdaemon", "entity_update", null, new NetdaemonEntityUpdateParameters { EntityId = entityId, State = state, Icon = icon, Unit = unit, Options = options, Attributes = attributes });
    }

    ///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
    public void RegisterService(NetdaemonRegisterServiceParameters data)
    {
        _haContext.CallService("netdaemon", "register_service", null, data);
    }

    ///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
    ///<param name="service">The name of the service to register</param>
    ///<param name="class">The class that implements the service call</param>
    ///<param name="method">The method to call</param>
    public void RegisterService(object? service = null, object? @class = null, object? @method = null)
    {
        _haContext.CallService("netdaemon", "register_service", null, new NetdaemonRegisterServiceParameters { Service = service, Class = @class, Method = @method });
    }

    public void ReloadApps(object? data = null)
    {
        _haContext.CallService("netdaemon", "reload_apps", null, data);
    }
}