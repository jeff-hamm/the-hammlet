//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-03T13:48:14.0536695-08:00
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
public partial class FfmpegServices
{
    private readonly IHaContext _haContext;
    public FfmpegServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Sends a restart command to a ffmpeg based sensor.</summary>
    public void Restart(FfmpegRestartParameters data)
    {
        _haContext.CallService("ffmpeg", "restart", null, data);
    }

    ///<summary>Sends a restart command to a ffmpeg based sensor.</summary>
    ///<param name="entityId">Name of entity that will restart. Platform dependent.</param>
    public void Restart(string? entityId = null)
    {
        _haContext.CallService("ffmpeg", "restart", null, new FfmpegRestartParameters { EntityId = entityId });
    }

    ///<summary>Sends a start command to a ffmpeg based sensor.</summary>
    public void Start(FfmpegStartParameters data)
    {
        _haContext.CallService("ffmpeg", "start", null, data);
    }

    ///<summary>Sends a start command to a ffmpeg based sensor.</summary>
    ///<param name="entityId">Name of entity that will start. Platform dependent.</param>
    public void Start(string? entityId = null)
    {
        _haContext.CallService("ffmpeg", "start", null, new FfmpegStartParameters { EntityId = entityId });
    }

    ///<summary>Sends a stop command to a ffmpeg based sensor.</summary>
    public void Stop(FfmpegStopParameters data)
    {
        _haContext.CallService("ffmpeg", "stop", null, data);
    }

    ///<summary>Sends a stop command to a ffmpeg based sensor.</summary>
    ///<param name="entityId">Name of entity that will stop. Platform dependent.</param>
    public void Stop(string? entityId = null)
    {
        _haContext.CallService("ffmpeg", "stop", null, new FfmpegStopParameters { EntityId = entityId });
    }
}