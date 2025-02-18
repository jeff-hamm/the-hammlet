//------------------------------------------------------------------------------
// <auto-generated>
// Generated using NetDaemon CodeGenerator nd-codegen v1.0.0.0
//   At: 2025-02-09T17:22:16.5267841-08:00
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
public partial class O365Services
{
    private readonly IHaContext _haContext;
    public O365Services(IHaContext haContext)
    {
        _haContext = haContext;
    }

    ///<summary>Complete a ToDo</summary>
    ///<param name="target">The target for this service call</param>
    public void CompleteTodo(ServiceTarget target, O365CompleteTodoParameters data)
    {
        _haContext.CallService("o365", "complete_todo", target, data);
    }

    ///<summary>Complete a ToDo</summary>
    ///<param name="todoId">ID for the todo, can be found as an attribute on your todo eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
    ///<param name="completed">Set whether todo is completed or not eg: True</param>
    public void CompleteTodo(ServiceTarget target, string todoId, bool completed)
    {
        _haContext.CallService("o365", "complete_todo", target, new O365CompleteTodoParameters { TodoId = todoId, Completed = completed });
    }

    ///<summary>Create new calendar event</summary>
    ///<param name="target">The target for this service call</param>
    public void CreateCalendarEvent(ServiceTarget target, O365CreateCalendarEventParameters data)
    {
        _haContext.CallService("o365", "create_calendar_event", target, data);
    }

    ///<summary>Create new calendar event</summary>
    ///<param name="subject">The subject of the created event eg: Clean up the garage</param>
    ///<param name="start">The start time of the event eg: 2025-03-22 20:00:00</param>
    ///<param name="end">The end time of the event eg: 2025-03-22 20:30:00</param>
    ///<param name="body">The body text for the event (optional) eg: Remember to also clean out the gutters</param>
    ///<param name="location">The location for the event (optional) eg: 1600 Pennsylvania Ave Nw, Washington, DC 20500</param>
    ///<param name="categories">list of categories for the event (optional)</param>
    ///<param name="sensitivity">The sensitivity for the event (optional) [Normal, Personal, Private, Confidential] eg: normal</param>
    ///<param name="showAs">Show event as (optional) [Free, Tentative, Busy, Oof, WorkingElsewhere, Unknown] eg: busy</param>
    ///<param name="isAllDay">Set whether event is all day (optional) eg: False</param>
    ///<param name="attendees">list of attendees formatted as email: example@example.com type: Required, Optional, or Resource (optional)</param>
    public void CreateCalendarEvent(ServiceTarget target, string subject, DateTime start, DateTime end, string? body = null, string? location = null, string? categories = null, object? sensitivity = null, object? showAs = null, bool? isAllDay = null, object? attendees = null)
    {
        _haContext.CallService("o365", "create_calendar_event", target, new O365CreateCalendarEventParameters { Subject = subject, Start = start, End = end, Body = body, Location = location, Categories = categories, Sensitivity = sensitivity, ShowAs = showAs, IsAllDay = isAllDay, Attendees = attendees });
    }

    ///<summary>Delete a ToDo</summary>
    ///<param name="target">The target for this service call</param>
    public void DeleteTodo(ServiceTarget target, O365DeleteTodoParameters data)
    {
        _haContext.CallService("o365", "delete_todo", target, data);
    }

    ///<summary>Delete a ToDo</summary>
    ///<param name="todoId">ID for the todo, can be found as an attribute on your todo eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
    public void DeleteTodo(ServiceTarget target, string todoId)
    {
        _haContext.CallService("o365", "delete_todo", target, new O365DeleteTodoParameters { TodoId = todoId });
    }

    ///<summary>Create disabled MS365 config entries based on existing O365 config</summary>
    public void MigrateConfig(object? data = null)
    {
        _haContext.CallService("o365", "migrate_config", null, data);
    }

    ///<summary>Modify existing calendar event, all properties except event_id are optional.</summary>
    ///<param name="target">The target for this service call</param>
    public void ModifyCalendarEvent(ServiceTarget target, O365ModifyCalendarEventParameters data)
    {
        _haContext.CallService("o365", "modify_calendar_event", target, data);
    }

    ///<summary>Modify existing calendar event, all properties except event_id are optional.</summary>
    ///<param name="eventId">ID for the event, can be found as an attribute on you calendar entity&apos;s events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
    ///<param name="subject">The subject of the created event eg: Clean up the garage</param>
    ///<param name="start">The start time of the event eg: 2025-03-22 20:00:00</param>
    ///<param name="end">The end time of the event eg: 2025-03-22 20:30:00</param>
    ///<param name="body">The body text for the event eg: Remember to also clean out the gutters</param>
    ///<param name="location">The location for the event eg: 1600 Pennsylvania Ave Nw, Washington, DC 20500</param>
    ///<param name="categories">list of categories for the event</param>
    ///<param name="sensitivity">The sensitivity for the event[Normal, Personal, Private, Confidential] eg: normal</param>
    ///<param name="showAs">Show event as [Free, Tentative, Busy, Oof, WorkingElsewhere, Unknown] eg: busy</param>
    ///<param name="isAllDay">Set whether event is all day eg: False</param>
    ///<param name="attendees">list of attendees formatted as email: example@example.com type: Required, Optional, or Resource</param>
    public void ModifyCalendarEvent(ServiceTarget target, string eventId, string? subject = null, DateTime? start = null, DateTime? end = null, string? body = null, string? location = null, string? categories = null, object? sensitivity = null, object? showAs = null, bool? isAllDay = null, object? attendees = null)
    {
        _haContext.CallService("o365", "modify_calendar_event", target, new O365ModifyCalendarEventParameters { EventId = eventId, Subject = subject, Start = start, End = end, Body = body, Location = location, Categories = categories, Sensitivity = sensitivity, ShowAs = showAs, IsAllDay = isAllDay, Attendees = attendees });
    }

    ///<summary>Create a new ToDo</summary>
    ///<param name="target">The target for this service call</param>
    public void NewTodo(ServiceTarget target, O365NewTodoParameters data)
    {
        _haContext.CallService("o365", "new_todo", target, data);
    }

    ///<summary>Create a new ToDo</summary>
    ///<param name="subject">The subject of the todo eg: Pick up the mail</param>
    ///<param name="description">Description of the todo eg: Walk to the post box and collect the mail</param>
    ///<param name="due">When the todo is due by eg: &quot;2025-01-01&quot;</param>
    ///<param name="reminder">When a reminder is needed eg: 2025-01-01T12:00:00+0000</param>
    public void NewTodo(ServiceTarget target, string subject, string? description = null, DateOnly? due = null, DateTime? reminder = null)
    {
        _haContext.CallService("o365", "new_todo", target, new O365NewTodoParameters { Subject = subject, Description = description, Due = due, Reminder = reminder });
    }

    ///<summary>Delete calendar event</summary>
    ///<param name="target">The target for this service call</param>
    public void RemoveCalendarEvent(ServiceTarget target, O365RemoveCalendarEventParameters data)
    {
        _haContext.CallService("o365", "remove_calendar_event", target, data);
    }

    ///<summary>Delete calendar event</summary>
    ///<param name="eventId">ID for the event, can be found as an attribute on you calendar entity&apos;s events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
    public void RemoveCalendarEvent(ServiceTarget target, string eventId)
    {
        _haContext.CallService("o365", "remove_calendar_event", target, new O365RemoveCalendarEventParameters { EventId = eventId });
    }

    ///<summary>Respond to calendar event/invite</summary>
    ///<param name="target">The target for this service call</param>
    public void RespondCalendarEvent(ServiceTarget target, O365RespondCalendarEventParameters data)
    {
        _haContext.CallService("o365", "respond_calendar_event", target, data);
    }

    ///<summary>Respond to calendar event/invite</summary>
    ///<param name="eventId">ID for event, can be found as an attribute on your calendar entity&apos;s events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
    ///<param name="response">The response to the invite [Accept, Tentative, Decline] eg: Decline</param>
    ///<param name="message">The response message to the invite (Optional) eg: I cannot attend this meeting</param>
    ///<param name="sendResponse">Send the response to the organizer (Optional) eg: True</param>
    public void RespondCalendarEvent(ServiceTarget target, string eventId, string response, string? message = null, bool? sendResponse = null)
    {
        _haContext.CallService("o365", "respond_calendar_event", target, new O365RespondCalendarEventParameters { EventId = eventId, Response = response, Message = message, SendResponse = sendResponse });
    }

    ///<summary>Scan for newly available calendars</summary>
    public void ScanForCalendars(object? data = null)
    {
        _haContext.CallService("o365", "scan_for_calendars", null, data);
    }

    ///<summary>Scan for newly available todo lists</summary>
    public void ScanForTodoLists(object? data = null)
    {
        _haContext.CallService("o365", "scan_for_todo_lists", null, data);
    }

    ///<summary>Update a ToDo</summary>
    ///<param name="target">The target for this service call</param>
    public void UpdateTodo(ServiceTarget target, O365UpdateTodoParameters data)
    {
        _haContext.CallService("o365", "update_todo", target, data);
    }

    ///<summary>Update a ToDo</summary>
    ///<param name="todoId">ID for the todo, can be found as an attribute on your todo eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
    ///<param name="subject">The subject of the todo eg: Pick up the mail</param>
    ///<param name="description">Description of the todo eg: Walk to the post box and collect the mail</param>
    ///<param name="due">When the todo is due by eg: &quot;2025-01-01&quot;</param>
    ///<param name="reminder">When a reminder is needed eg: 2025-01-01T12:00:00+0000</param>
    public void UpdateTodo(ServiceTarget target, string todoId, string? subject = null, string? description = null, DateOnly? due = null, DateTime? reminder = null)
    {
        _haContext.CallService("o365", "update_todo", target, new O365UpdateTodoParameters { TodoId = todoId, Subject = subject, Description = description, Due = due, Reminder = reminder });
    }
}