using Hammlet.NetDaemon.Models;

namespace HassModel;

public static class ContextExtensions
{
    public static LightEntity LightEntity(this IHaContext @this, string entityId) =>
        new (@this.Entity(entityId));
}