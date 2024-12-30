// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names

using System.Linq;
using System.Text.Json;
using Hammlet.NetDaemon.Models;
using NetDaemon.HassModel.Entities;

namespace HassModel;

/// <summary>
///     Showcase using the new HassModel API and turn on light on movement
/// </summary>
[NetDaemonApp]
public class SceneOnButton
{
    private static readonly JsonSerializerOptions o = new()
    {
        WriteIndented = true,
    };
    public SceneOnButton(IHaContext ha, EventEntities events, LightEntities lights)
    {
        lights.KitchenLight.PrintEntityInfo();
        events.AliveRemoteRemoteControl.StateChanges().Subscribe(e =>
        {
            if (e.Entity == events.AliveRemoteRemoteControlSwitchScene001 &&
                e.Entity.EventType<ZWaveSceneSelectorEventTypes>() == ZWaveSceneSelectorEventTypes.KeyPressed)
                lights.Living.Toggle();
            if (e.Entity == events.AliveRemoteRemoteControlSwitchScene003 &&
                e.Entity.EventType<ZWaveSceneSelectorEventTypes>() == ZWaveSceneSelectorEventTypes.KeyPressed)
                lights.Living.Brighten();
            if (e.Entity == events.AliveRemoteRemoteControlSwitchScene004 &&
                e.Entity.EventType<ZWaveSceneSelectorEventTypes>() == ZWaveSceneSelectorEventTypes.KeyPressed)
                lights.Living.Darken();
        });
    }

    private static string Serialize(Event e)
    {
        return JsonSerializer.Serialize(e.DataElement, o);
    }
}
