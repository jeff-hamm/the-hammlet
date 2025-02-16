//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-14T18:42:13.0825230-08:00
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

namespace HomeAssistantGenerated;
public partial class HassioServices
{
    private readonly IHaContext _haContext;
    public HassioServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Restarts an add-on.</summary>
    public void AddonRestart(HassioAddonRestartParameters data)
    {
        _haContext.CallService("hassio", "addon_restart", null, data);
    }

    ///<summary>Restarts an add-on.</summary>
    ///<param name="addon">The add-on to restart. eg: core_ssh</param>
    public void AddonRestart(object addon)
    {
        _haContext.CallService("hassio", "addon_restart", null, new HassioAddonRestartParameters { Addon = addon });
    }

    ///<summary>Starts an add-on.</summary>
    public void AddonStart(HassioAddonStartParameters data)
    {
        _haContext.CallService("hassio", "addon_start", null, data);
    }

    ///<summary>Starts an add-on.</summary>
    ///<param name="addon">The add-on to start. eg: core_ssh</param>
    public void AddonStart(object addon)
    {
        _haContext.CallService("hassio", "addon_start", null, new HassioAddonStartParameters { Addon = addon });
    }

    ///<summary>Writes data to the add-on&apos;s standard input.</summary>
    public void AddonStdin(HassioAddonStdinParameters data)
    {
        _haContext.CallService("hassio", "addon_stdin", null, data);
    }

    ///<summary>Writes data to the add-on&apos;s standard input.</summary>
    ///<param name="addon">The add-on to write to. eg: core_ssh</param>
    public void AddonStdin(object addon)
    {
        _haContext.CallService("hassio", "addon_stdin", null, new HassioAddonStdinParameters { Addon = addon });
    }

    ///<summary>Stops an add-on.</summary>
    public void AddonStop(HassioAddonStopParameters data)
    {
        _haContext.CallService("hassio", "addon_stop", null, data);
    }

    ///<summary>Stops an add-on.</summary>
    ///<param name="addon">The add-on to stop. eg: core_ssh</param>
    public void AddonStop(object addon)
    {
        _haContext.CallService("hassio", "addon_stop", null, new HassioAddonStopParameters { Addon = addon });
    }

    ///<summary>Updates an add-on. This action should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
    public void AddonUpdate(HassioAddonUpdateParameters data)
    {
        _haContext.CallService("hassio", "addon_update", null, data);
    }

    ///<summary>Updates an add-on. This action should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
    ///<param name="addon">The add-on to update. eg: core_ssh</param>
    public void AddonUpdate(object addon)
    {
        _haContext.CallService("hassio", "addon_update", null, new HassioAddonUpdateParameters { Addon = addon });
    }

    ///<summary>Creates a full backup.</summary>
    public void BackupFull(HassioBackupFullParameters data)
    {
        _haContext.CallService("hassio", "backup_full", null, data);
    }

    ///<summary>Creates a full backup.</summary>
    ///<param name="name">Optional (default = current date and time). eg: Backup 1</param>
    ///<param name="password">Password to protect the backup with. eg: password</param>
    ///<param name="compressed">Compresses the backup files.</param>
    ///<param name="location">Name of a backup network storage to host backups. eg: my_backup_mount</param>
    ///<param name="homeassistantExcludeDatabase">Exclude the Home Assistant database file from backup</param>
    public void BackupFull(string? name = null, string? password = null, bool? compressed = null, object? location = null, bool? homeassistantExcludeDatabase = null)
    {
        _haContext.CallService("hassio", "backup_full", null, new HassioBackupFullParameters { Name = name, Password = password, Compressed = compressed, Location = location, HomeassistantExcludeDatabase = homeassistantExcludeDatabase });
    }

    ///<summary>Creates a partial backup.</summary>
    public void BackupPartial(HassioBackupPartialParameters data)
    {
        _haContext.CallService("hassio", "backup_partial", null, data);
    }

    ///<summary>Creates a partial backup.</summary>
    ///<param name="homeassistant">Includes Home Assistant settings in the backup.</param>
    ///<param name="homeassistantExcludeDatabase">Exclude the Home Assistant database file from backup</param>
    ///<param name="addons">List of add-ons to include in the backup. Use the name slug of each add-on. eg: [&quot;core_ssh&quot;,&quot;core_samba&quot;,&quot;core_mosquitto&quot;]</param>
    ///<param name="folders">List of directories to include in the backup. eg: [&quot;homeassistant&quot;,&quot;share&quot;]</param>
    ///<param name="name">Optional (default = current date and time). eg: Partial backup 1</param>
    ///<param name="password">Password to protect the backup with. eg: password</param>
    ///<param name="compressed">Compresses the backup files.</param>
    ///<param name="location">Name of a backup network storage to host backups. eg: my_backup_mount</param>
    public void BackupPartial(bool? homeassistant = null, bool? homeassistantExcludeDatabase = null, object? addons = null, object? folders = null, string? name = null, string? password = null, bool? compressed = null, object? location = null)
    {
        _haContext.CallService("hassio", "backup_partial", null, new HassioBackupPartialParameters { Homeassistant = homeassistant, HomeassistantExcludeDatabase = homeassistantExcludeDatabase, Addons = addons, Folders = folders, Name = name, Password = password, Compressed = compressed, Location = location });
    }

    ///<summary>Reboots the host system.</summary>
    public void HostReboot(object? data = null)
    {
        _haContext.CallService("hassio", "host_reboot", null, data);
    }

    ///<summary>Powers off the host system.</summary>
    public void HostShutdown(object? data = null)
    {
        _haContext.CallService("hassio", "host_shutdown", null, data);
    }

    ///<summary>Restores from full backup.</summary>
    public void RestoreFull(HassioRestoreFullParameters data)
    {
        _haContext.CallService("hassio", "restore_full", null, data);
    }

    ///<summary>Restores from full backup.</summary>
    ///<param name="slug">Slug of backup to restore from.</param>
    ///<param name="password">Optional password. eg: password</param>
    public void RestoreFull(string slug, string? password = null)
    {
        _haContext.CallService("hassio", "restore_full", null, new HassioRestoreFullParameters { Slug = slug, Password = password });
    }

    ///<summary>Restores from a partial backup.</summary>
    public void RestorePartial(HassioRestorePartialParameters data)
    {
        _haContext.CallService("hassio", "restore_partial", null, data);
    }

    ///<summary>Restores from a partial backup.</summary>
    ///<param name="slug">Slug of backup to restore from.</param>
    ///<param name="homeassistant">Restores Home Assistant.</param>
    ///<param name="folders">List of directories to restore from the backup. eg: [&quot;homeassistant&quot;,&quot;share&quot;]</param>
    ///<param name="addons">List of add-ons to restore from the backup. Use the name slug of each add-on. eg: [&quot;core_ssh&quot;,&quot;core_samba&quot;,&quot;core_mosquitto&quot;]</param>
    ///<param name="password">Optional password. eg: password</param>
    public void RestorePartial(string slug, bool? homeassistant = null, object? folders = null, object? addons = null, string? password = null)
    {
        _haContext.CallService("hassio", "restore_partial", null, new HassioRestorePartialParameters { Slug = slug, Homeassistant = homeassistant, Folders = folders, Addons = addons, Password = password });
    }
}