using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using NetDaemon.Client;
using NetDaemon.Client.HomeAssistant.Extensions;
using NetDaemon.Client.HomeAssistant.Model;
using NetDaemon.HassModel.Entities;

namespace Hammlet.Extensions;

public interface IAsyncHaContext : IHaContext
{
    public Task CallServiceAsync(string domain,
        string service,
        object? serviceData = null,
        HassTarget? target = null,
        CancellationToken? cancelToken = null);


}
internal class AsyncHaContext(IHaContext baseContext, IHomeAssistantRunner hassRunner) : IAsyncHaContext
{
    public IObservable<StateChange> StateAllChanges() => baseContext.StateAllChanges();

    public EntityState? GetState(string entityId) => baseContext.GetState(entityId);

    public IReadOnlyList<Entity> GetAllEntities()
    {
        return baseContext.GetAllEntities();
    }

    public void CallService(string domain, string service, ServiceTarget? target = null, object? data = null)
    {
        baseContext.CallService(domain, service, target, data);
    }

    public Task<JsonElement?> CallServiceWithResponseAsync(string domain, string service, ServiceTarget? target = null, object? data = null)
    {
        return baseContext.CallServiceWithResponseAsync(domain, service, target, data);
    }

    public Area? GetAreaFromEntityId(string entityId)
    {
        return baseContext.GetAreaFromEntityId(entityId);
    }

    public EntityRegistration? GetEntityRegistration(string entityId)
    {
        return baseContext.GetEntityRegistration(entityId);
    }

    public void SendEvent(string eventType, object? data = null)
    {
        baseContext.SendEvent(eventType, data);
    }

    public IObservable<Event> Events => baseContext.Events;

    public Task CallServiceAsync(string domain,
        string service,
        object? serviceData = null,
        HassTarget? target = null,
        CancellationToken? cancelToken = null
    ) => hassRunner.CurrentConnection?.CallServiceAsync(domain, service, serviceData, target, cancelToken) ?? throw new InvalidOperationException("No connection found");
}
