//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T15:53:27.9517073-08:00
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
public partial class LocaltuyaServices
{
    private readonly IHaContext _haContext;
    public LocaltuyaServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Reload localtuya and reconnect to all devices.</summary>
    public void Reload(object? data = null)
    {
        _haContext.CallService("localtuya", "reload", null, data);
    }

    ///<summary>Change the value of a datapoint (DP)</summary>
    public void SetDp(LocaltuyaSetDpParameters data)
    {
        _haContext.CallService("localtuya", "set_dp", null, data);
    }

    ///<summary>Change the value of a datapoint (DP)</summary>
    ///<param name="deviceId">Device ID of device to change datapoint value for eg: 11100118278aab4de001</param>
    ///<param name="dp">Datapoint index eg: 1</param>
    ///<param name="value">New value to set eg: False</param>
    public void SetDp(object? deviceId = null, object? dp = null, object? value = null)
    {
        _haContext.CallService("localtuya", "set_dp", null, new LocaltuyaSetDpParameters { DeviceId = deviceId, Dp = dp, Value = value });
    }
}