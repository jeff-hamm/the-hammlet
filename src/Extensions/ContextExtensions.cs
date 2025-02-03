using System.Collections.Generic;
using System.Linq;
using Hammlet.NetDaemon.Models;

using NetDaemon.HassModel.Entities;

namespace HassModel;



public static class ContextExtensions
{

    public static IEnumerable<EventEntity> Events(this IHaContext @this, IEnumerable<string> entityIds) =>
        @this.Entities<EventEntity>(entityIds);
    public static IEnumerable<TEntity> Entities<TEntity>(this IHaContext @this, IEnumerable<string> entityIds) 
        where TEntity : Entity
        => entityIds.Select(e => 
            (TEntity)Activator.CreateInstance(typeof(TEntity), @this,e)!);
    public static TEntity Entity<TEntity>(this IHaContext @this, string entityId) where TEntity:Entity =>
        (TEntity)@this.Entity(entityId);

    public static LightEntity LightEntity(this IHaContext @this, string entityId) =>
        new (@this.Entity(entityId));
}