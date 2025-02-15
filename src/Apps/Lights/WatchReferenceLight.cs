// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names

using System.Collections.Generic;
using System.Linq;
using Hammlet.Config;
using Hammlet.NetDaemon.Extensions;
using Hammlet.NetDaemon.Models;
using HassModel;
using NetDaemon.HassModel.Entities;

namespace Hammlet.Apps.Lights;

/// <summary>
///     Showcase using the new HassModel API and turn on light on movement
/// </summary>
[NetDaemonApp]
public class WatchReferenceLight
{
    public WatchReferenceLight(IHaContext ha, LightEntities entities, IAppConfig<ReferenceLight> config)
    {
        string refId = config.Value.EntityId;
        var ids =
            config.Value.TrackedEntities.SelectMany(e => GetEntities(ha, e)).Distinct().ToArray();
//            (entities.ColorBulbs.EntityState?.Attributes?.EntityId ?? []).Union(trackedEntities.Select(s => s.EntityId).ToArray());
        ha.StateChanges().Where(s => 
            ids.Contains(s.Entity.EntityId) &&
                (s.New?.IsOn() == true && s.Old?.IsOff() == true))
            .Subscribe(e =>
            {
                var referenceEntity = new LightEntity(ha.Entity(refId));
                    if (referenceEntity.IsOn())
                    {
                        var l = new LightEntity(e.Entity);
                        if (l.CopyParameters(referenceEntity) is { } parameters)
                        {
                            l.TurnOn(parameters);
                        }
                    }
            });
        ha.LightEntity(config.Value.EntityId).StateAllChanges().Subscribe(e =>
        {
            if (e.Entity.IsOff()) return;
            foreach (var id in ids)
            {
                var l = new LightEntity(ha.Entity(id));
                if (l.IsOn() &&
                    l.CopyParameters(e.Entity) is { } parameters)
                {
                    l.TurnOn(parameters);
                }
            }
        });
    }

    private IEnumerable<string> GetEntities(IHaContext ha, string s)
    {
        if (new LightEntity(ha, s).EntityState?.Attributes?.EntityId is { } entities)
        {
            foreach(var entity in entities.Select(s => s.ToJsonName()))
            {
                foreach(var e in GetEntities(ha,entity))
                    yield return entity;
            }
        }
        else
            yield return s;
    }
}