//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.0420400-08:00
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
public partial class DeviceTrackerServices
{
    private readonly IHaContext _haContext;
    public DeviceTrackerServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Manually update the records of a seen legacy device tracker in the known_devices.yaml file.</summary>
    public void See(DeviceTrackerSeeParameters data)
    {
        _haContext.CallService("device_tracker", "see", null, data);
    }

    ///<summary>Manually update the records of a seen legacy device tracker in the known_devices.yaml file.</summary>
    ///<param name="mac">MAC address of the device. eg: FF:FF:FF:FF:FF:FF</param>
    ///<param name="devId">ID of the device (find the ID in `known_devices.yaml`). eg: phonedave</param>
    ///<param name="hostName">Hostname of the device. eg: Dave</param>
    ///<param name="locationName">Name of the location where the device is located. The options are: `home`, `not_home`, or the name of the zone. eg: home</param>
    ///<param name="gps">GPS coordinates where the device is located, specified by latitude and longitude (for example: [51.513845, -0.100539]). eg: [51.509802, -0.086692]</param>
    ///<param name="gpsAccuracy">Accuracy of the GPS coordinates.</param>
    ///<param name="battery">Battery level of the device.</param>
    public void See(string? mac = null, string? devId = null, string? hostName = null, string? locationName = null, object? gps = null, double? gpsAccuracy = null, double? battery = null)
    {
        _haContext.CallService("device_tracker", "see", null, new DeviceTrackerSeeParameters { Mac = mac, DevId = devId, HostName = hostName, LocationName = locationName, Gps = gps, GpsAccuracy = gpsAccuracy, Battery = battery });
    }
}