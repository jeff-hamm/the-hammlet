using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
    public static BinarySensorEntity BinarySensor(this IHaContext @this, string entityId) =>
        new (@this.Entity(EntityIdHelper.EnsureDomain(entityId,"binary_sensor")));

}
internal static class EntityIdHelper
{
    public static readonly string[] NumericDomains = ["input_number", "number", "proximity"];
    public static readonly string[] MixedDomains = ["sensor"];

    private static readonly Regex domainRegex = new Regex(@"^(?<domain>[^\.]+\.)(?<entity>.+)$");
    public static string EnsureDomain(string entityId, string domain)
    {
        if (domainRegex.Match(entityId) is not {Success:true} m) return entityId;
        return domain + "." + m.Groups["entity"];

    }
    public static string GetDomain(string str)
    {
        return str[..str.IndexOf('.', StringComparison.InvariantCultureIgnoreCase)];
    }

    public static string GetEntity(string str)
    {
        return str[(str.IndexOf('.', StringComparison.InvariantCultureIgnoreCase) + 1)..];
    }
}