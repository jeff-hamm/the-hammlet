//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.5085422-08:00
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
public partial class NotifyServices
{
    private readonly IHaContext _haContext;
    public NotifyServices(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Sends a notification message using the lg_webos_tv_oled65c1pub service.</summary>
    public void LgWebosTvOled65c1pub(NotifyLgWebosTvOled65c1pubParameters data)
    {
        _haContext.CallService("notify", "lg_webos_tv_oled65c1pub", null, data);
    }

    ///<summary>Sends a notification message using the lg_webos_tv_oled65c1pub service.</summary>
    ///<param name="message"> eg: The garage door has been open for 10 minutes.</param>
    ///<param name="title"> eg: Your Garage Door Friend</param>
    ///<param name="target"> eg: platform specific</param>
    ///<param name="data"> eg: platform specific</param>
    public void LgWebosTvOled65c1pub(string message, string? title = null, object? target = null, object? data = null)
    {
        _haContext.CallService("notify", "lg_webos_tv_oled65c1pub", null, new NotifyLgWebosTvOled65c1pubParameters { Message = message, Title = title, Target = target, Data = data });
    }

    ///<summary>Sends a notification message using the mobile_app_briana_s_iphone integration.</summary>
    public void MobileAppBrianaSIphone(NotifyMobileAppBrianaSIphoneParameters data)
    {
        _haContext.CallService("notify", "mobile_app_briana_s_iphone", null, data);
    }

    ///<summary>Sends a notification message using the mobile_app_briana_s_iphone integration.</summary>
    ///<param name="message"> eg: The garage door has been open for 10 minutes.</param>
    ///<param name="title"> eg: Your Garage Door Friend</param>
    ///<param name="target"> eg: platform specific</param>
    ///<param name="data"> eg: platform specific</param>
    public void MobileAppBrianaSIphone(string message, string? title = null, object? target = null, object? data = null)
    {
        _haContext.CallService("notify", "mobile_app_briana_s_iphone", null, new NotifyMobileAppBrianaSIphoneParameters { Message = message, Title = title, Target = target, Data = data });
    }

    ///<summary>Sends a notification message using the mobile_app_mikaela integration.</summary>
    public void MobileAppMikaela(NotifyMobileAppMikaelaParameters data)
    {
        _haContext.CallService("notify", "mobile_app_mikaela", null, data);
    }

    ///<summary>Sends a notification message using the mobile_app_mikaela integration.</summary>
    ///<param name="message"> eg: The garage door has been open for 10 minutes.</param>
    ///<param name="title"> eg: Your Garage Door Friend</param>
    ///<param name="target"> eg: platform specific</param>
    ///<param name="data"> eg: platform specific</param>
    public void MobileAppMikaela(string message, string? title = null, object? target = null, object? data = null)
    {
        _haContext.CallService("notify", "mobile_app_mikaela", null, new NotifyMobileAppMikaelaParameters { Message = message, Title = title, Target = target, Data = data });
    }

    ///<summary>Sends a notification message using the mobile_app_pixel_8 integration.</summary>
    public void MobileAppPixel8(NotifyMobileAppPixel8Parameters data)
    {
        _haContext.CallService("notify", "mobile_app_pixel_8", null, data);
    }

    ///<summary>Sends a notification message using the mobile_app_pixel_8 integration.</summary>
    ///<param name="message"> eg: The garage door has been open for 10 minutes.</param>
    ///<param name="title"> eg: Your Garage Door Friend</param>
    ///<param name="target"> eg: platform specific</param>
    ///<param name="data"> eg: platform specific</param>
    public void MobileAppPixel8(string message, string? title = null, object? target = null, object? data = null)
    {
        _haContext.CallService("notify", "mobile_app_pixel_8", null, new NotifyMobileAppPixel8Parameters { Message = message, Title = title, Target = target, Data = data });
    }

    ///<summary>Sends a notification message using the mobile_app_stuarts_iphone integration.</summary>
    public void MobileAppStuartsIphone(NotifyMobileAppStuartsIphoneParameters data)
    {
        _haContext.CallService("notify", "mobile_app_stuarts_iphone", null, data);
    }

    ///<summary>Sends a notification message using the mobile_app_stuarts_iphone integration.</summary>
    ///<param name="message"> eg: The garage door has been open for 10 minutes.</param>
    ///<param name="title"> eg: Your Garage Door Friend</param>
    ///<param name="target"> eg: platform specific</param>
    ///<param name="data"> eg: platform specific</param>
    public void MobileAppStuartsIphone(string message, string? title = null, object? target = null, object? data = null)
    {
        _haContext.CallService("notify", "mobile_app_stuarts_iphone", null, new NotifyMobileAppStuartsIphoneParameters { Message = message, Title = title, Target = target, Data = data });
    }

    ///<summary>Sends a notification message using the mobile_app_wallfire integration.</summary>
    public void MobileAppWallfire(NotifyMobileAppWallfireParameters data)
    {
        _haContext.CallService("notify", "mobile_app_wallfire", null, data);
    }

    ///<summary>Sends a notification message using the mobile_app_wallfire integration.</summary>
    ///<param name="message"> eg: The garage door has been open for 10 minutes.</param>
    ///<param name="title"> eg: Your Garage Door Friend</param>
    ///<param name="target"> eg: platform specific</param>
    ///<param name="data"> eg: platform specific</param>
    public void MobileAppWallfire(string message, string? title = null, object? target = null, object? data = null)
    {
        _haContext.CallService("notify", "mobile_app_wallfire", null, new NotifyMobileAppWallfireParameters { Message = message, Title = title, Target = target, Data = data });
    }

    ///<summary>Sends a notification message using the notify service.</summary>
    public void Notify(NotifyNotifyParameters data)
    {
        _haContext.CallService("notify", "notify", null, data);
    }

    ///<summary>Sends a notification message using the notify service.</summary>
    ///<param name="message"> eg: The garage door has been open for 10 minutes.</param>
    ///<param name="title"> eg: Your Garage Door Friend</param>
    ///<param name="target"> eg: platform specific</param>
    ///<param name="data"> eg: platform specific</param>
    public void Notify(string message, string? title = null, object? target = null, object? data = null)
    {
        _haContext.CallService("notify", "notify", null, new NotifyNotifyParameters { Message = message, Title = title, Target = target, Data = data });
    }

    ///<summary>Sends a notification message using the o365_email_jeff_hamm integration.</summary>
    public void O365EmailJeffHamm(NotifyO365EmailJeffHammParameters data)
    {
        _haContext.CallService("notify", "o365_email_jeff_hamm", null, data);
    }

    ///<summary>Sends a notification message using the o365_email_jeff_hamm integration.</summary>
    ///<param name="message"> eg: The garage door has been open for 10 minutes.</param>
    ///<param name="title"> eg: Your Garage Door Friend</param>
    ///<param name="target"> eg: platform specific</param>
    ///<param name="data"> eg: platform specific</param>
    public void O365EmailJeffHamm(string message, string? title = null, object? target = null, object? data = null)
    {
        _haContext.CallService("notify", "o365_email_jeff_hamm", null, new NotifyO365EmailJeffHammParameters { Message = message, Title = title, Target = target, Data = data });
    }

    ///<summary>Sends a notification that is visible in the notifications panel.</summary>
    public void PersistentNotification(NotifyPersistentNotificationParameters data)
    {
        _haContext.CallService("notify", "persistent_notification", null, data);
    }

    ///<summary>Sends a notification that is visible in the notifications panel.</summary>
    ///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
    ///<param name="title">Title of the notification. eg: Your Garage Door Friend</param>
    ///<param name="data">Some integrations provide extended functionality. For information on how to use _data_, refer to the integration documentation.. eg: platform specific</param>
    public void PersistentNotification(string message, string? title = null, object? data = null)
    {
        _haContext.CallService("notify", "persistent_notification", null, new NotifyPersistentNotificationParameters { Message = message, Title = title, Data = data });
    }

    ///<summary>Sends a notification message.</summary>
    ///<param name="target">The target for this service call</param>
    public void SendMessage(ServiceTarget target, NotifySendMessageParameters data)
    {
        _haContext.CallService("notify", "send_message", target, data);
    }

    ///<summary>Sends a notification message.</summary>
    ///<param name="message">Your notification message.</param>
    ///<param name="title">Title for your notification message.</param>
    public void SendMessage(ServiceTarget target, string message, string? title = null)
    {
        _haContext.CallService("notify", "send_message", target, new NotifySendMessageParameters { Message = message, Title = title });
    }
}