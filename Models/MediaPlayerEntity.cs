using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompileTimeProxyGenerator;
using Hammlet.NetDaemon.Extensions;
using Hammlet.NetDaemon.Models.Framework;
using NetDaemon.HassModel.Entities;

namespace Hammlet.NetDaemon.Models;


[Proxy(typeof(LightAttributes),ConvertTo = ConversionType.Implicit)]
public partial record ParsedLightAttributes
{
    public ColorMode ColorMode => _inner.ColorMode == "color_temp" ? Framework.ColorMode.ColorTemp  : (_inner.ColorMode?.ParseState<ColorMode>() ?? ColorMode.Unknown);

    public System.Collections.Generic.IEnumerable<ColorMode> SupportedColorModes =>
        _inner.SupportedColorModes?.ParseModes() ?? [];
}

public partial record MediaPlayerEntity
{
    public new MediaPlayerState? EntityState => base.EntityState != null ? (MediaPlayerState)base.EntityState : null;
    public new MediaPlayerStates State =>
        base.EntityState?.ParseState<MediaPlayerStates>() ?? MediaPlayerStates.Unknown;

//    public new MediaPlayerState? EntityState => new MediaPlayerState(base.EntityState);

    public new IObservable<StateChange<MediaPlayerEntity, MediaPlayerState>> StateChanges() =>
        ((Entity)this).StateChanges().Select(c => new StateChange<MediaPlayerEntity, MediaPlayerState>(
            (MediaPlayerEntity)c.Entity,
            MediaPlayerState.FromState(c.Old), MediaPlayerState.FromState(c.New)));
}
