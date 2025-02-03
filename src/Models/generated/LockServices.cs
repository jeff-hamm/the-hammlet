//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T15:53:27.9541031-08:00
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
public partial class LockServices
{
    private readonly IHaContext _haContext;
    public LockServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Locks a lock.</summary>
    ///<param name="target">The target for this service call</param>
    public void Lock(ServiceTarget target, LockLockParameters data)
    {
        _haContext.CallService("lock", "lock", target, data);
    }

    ///<summary>Locks a lock.</summary>
    ///<param name="code">Code used to lock the lock. eg: 1234</param>
    public void Lock(ServiceTarget target, string? code = null)
    {
        _haContext.CallService("lock", "lock", target, new LockLockParameters { Code = code });
    }

    ///<summary>Opens a lock.</summary>
    ///<param name="target">The target for this service call</param>
    public void Open(ServiceTarget target, LockOpenParameters data)
    {
        _haContext.CallService("lock", "open", target, data);
    }

    ///<summary>Opens a lock.</summary>
    ///<param name="code">Code used to open the lock. eg: 1234</param>
    public void Open(ServiceTarget target, string? code = null)
    {
        _haContext.CallService("lock", "open", target, new LockOpenParameters { Code = code });
    }

    ///<summary>Unlocks a lock.</summary>
    ///<param name="target">The target for this service call</param>
    public void Unlock(ServiceTarget target, LockUnlockParameters data)
    {
        _haContext.CallService("lock", "unlock", target, data);
    }

    ///<summary>Unlocks a lock.</summary>
    ///<param name="code">Code used to unlock the lock. eg: 1234</param>
    public void Unlock(ServiceTarget target, string? code = null)
    {
        _haContext.CallService("lock", "unlock", target, new LockUnlockParameters { Code = code });
    }
}