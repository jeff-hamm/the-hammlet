using System.Linq;
using Hammlet.Models.Enums;
using Hammlet.NetDaemon.Models;
using NetDaemon.HassModel.Entities;

namespace HassModel;

public static class EventExtensions
{
    public static IObservable<Event> Event(this EventEntity @this) =>
        @this.HaContext.Event(@this);
    public static IObservable<Event> Event(this IHaContext @this, EventEntity entity) =>
        @this.Events.Where(e => e.EventType == entity.EntityId);

    public static string? EventType(this EventEntity @this) => @this.Attributes?.EventType;
    public static TEnum? EventType<TEnum>(this EventEntity @this)
        where TEnum : struct
        => Enum.TryParse<TEnum>(@this.Attributes?.EventType, out var r) ? r : null;
    public static void PrintEntityInfo(this Entity? entity)
    {
        if (entity == null)
        {
            Console.WriteLine("Entity is null");
            return;
        }
        Console.WriteLine($"Info: {entity.EntityId}");
        Console.WriteLine(entity.ToString());
        Console.WriteLine(entity.HaContext.GetState(entity.EntityId)?.ToString());
        Console.WriteLine(entity.Attributes?.ToString());
        Console.WriteLine("Registration");
        Console.WriteLine(entity.Registration);
        Console.WriteLine("Device");
        Console.WriteLine(entity.Registration?.Device);
    }

}