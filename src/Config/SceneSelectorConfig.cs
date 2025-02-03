using System.Collections.Generic;
using System.Linq;
using Hammlet.Apps.SceneOnButton;
using Hammlet.NetDaemon.Models;

namespace Hammlet.Config;

public class SceneSelectorConfig
{
    internal Guid Id { get; } = Guid.NewGuid();
    public string TargetEntityId { get; set; } = "light.kitchen";

    public IEnumerable<string> ButtonEventIds => 
        Buttons.Select(button => $"{EventIdPrefix}{button.EventIndex}");

    public IEnumerable<LightButtonConfig> Buttons
    {
        get
        {
            yield return Button1;
            yield return Button2;
            yield return Button3;
            yield return Button4;
        }
    }

    public string EventIdPrefix { get; set; } = "event.alive_remote_scene_";

    public LightButtonConfig Button1 { get; set; } = new()
    {
        Action = ButtonAction.Brighten,
        Type = SceneSelectorEventTypes.KeyPressed,
        EventIndex = "001",
        On = new LightTurnOnParameters()
        {
            BrightnessStepPct = 25
        }
    };
    public LightButtonConfig Button2 { get; set; } = new()
    {
        Action = ButtonAction.Darken,
        EventIndex = "002",
        On = new LightTurnOnParameters()
        {
            BrightnessStepPct = 25
        }
    };
    public LightButtonConfig Button3 { get; set; } = new()
    {
        Action = ButtonAction.ToggleWarm,
        EventIndex = "003",
    };
    public LightButtonConfig Button4 { get; set; } = new()
    {
        Action = ButtonAction.TurnOff,
        EventIndex = "004",
    };

    public double BrightnessPct { get; set; } = 25;
}

public enum ButtonAction
{
    TurnOn, TurnOff, Brighten, Darken, ToggleWarm,
    Toggle
}

public partial record LightButtonConfig
{
    public ButtonAction Action { get; set; } = ButtonAction.Toggle;
    public LightTurnOnParameters? On { get; set; }
    public LightTurnOffParameters? Off { get; set; }
    public string EventIndex { get; set; } = "000";
    public SceneSelectorEventTypes Type { get; set; } = SceneSelectorEventTypes.KeyPressed;
}