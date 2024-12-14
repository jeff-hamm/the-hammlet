//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v24.50.0.0
//   At: 2024-12-14T14:51:18.8927722-08:00
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
public partial class WakeOnLanServices
{
    private readonly IHaContext _haContext;
    public WakeOnLanServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Sends a &apos;magic packet&apos; to wake up a device with &apos;Wake-On-LAN&apos; capabilities.</summary>
    public void SendMagicPacket(WakeOnLanSendMagicPacketParameters data)
    {
        _haContext.CallService("wake_on_lan", "send_magic_packet", null, data);
    }

    ///<summary>Sends a &apos;magic packet&apos; to wake up a device with &apos;Wake-On-LAN&apos; capabilities.</summary>
    ///<param name="mac">MAC address of the device to wake up. eg: aa:bb:cc:dd:ee:ff</param>
    ///<param name="broadcastAddress">The IP address of the host to send the magic packet to. Defaults to `255.255.255.255` and is normally not changed. eg: 192.168.255.255</param>
    ///<param name="broadcastPort">The port to send the magic packet to. Defaults to `9` and is normally not changed.</param>
    public void SendMagicPacket(string mac, string? broadcastAddress = null, double? broadcastPort = null)
    {
        _haContext.CallService("wake_on_lan", "send_magic_packet", null, new WakeOnLanSendMagicPacketParameters { Mac = mac, BroadcastAddress = broadcastAddress, BroadcastPort = broadcastPort });
    }
}