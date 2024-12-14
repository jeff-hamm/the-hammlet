//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v24.50.0.0
//   At: 2024-12-14T14:51:18.7337041-08:00
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
public partial class HumidifierServices
{
    private readonly IHaContext _haContext;
    public HumidifierServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Sets the target humidity.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetHumidity(ServiceTarget target, HumidifierSetHumidityParameters data)
    {
        _haContext.CallService("humidifier", "set_humidity", target, data);
    }

    ///<summary>Sets the target humidity.</summary>
    ///<param name="humidity">Target humidity.</param>
    public void SetHumidity(ServiceTarget target, double humidity)
    {
        _haContext.CallService("humidifier", "set_humidity", target, new HumidifierSetHumidityParameters { Humidity = humidity });
    }

    ///<summary>Sets the humidifier operation mode.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetMode(ServiceTarget target, HumidifierSetModeParameters data)
    {
        _haContext.CallService("humidifier", "set_mode", target, data);
    }

    ///<summary>Sets the humidifier operation mode.</summary>
    ///<param name="mode">Operation mode. For example, _normal_, _eco_, or _away_. For a list of possible values, refer to the integration documentation. eg: away</param>
    public void SetMode(ServiceTarget target, string mode)
    {
        _haContext.CallService("humidifier", "set_mode", target, new HumidifierSetModeParameters { Mode = mode });
    }

    ///<summary>Toggles the humidifier on/off.</summary>
    ///<param name="target">The target for this service call</param>
    public void Toggle(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("humidifier", "toggle", target, data);
    }

    ///<summary>Turns the humidifier off.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOff(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("humidifier", "turn_off", target, data);
    }

    ///<summary>Turns the humidifier on.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOn(ServiceTarget target, object? data = null)
    {
        _haContext.CallService("humidifier", "turn_on", target, data);
    }
}