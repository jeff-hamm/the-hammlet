using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Hammlet.NetDaemon.Models.Framework;
using NetDaemon.HassModel.Entities;

namespace Hammlet.NetDaemon.Models;


public interface IStateEntity<out TState> where TState : IParsable<TState>
{
    public EntityState? EntityState { get; }
}
public partial record LightAttributes
{
    [JsonIgnore] public ExtendedLightAttributes? Extended { get; init; } = new ExtendedLightAttributes();
}

public partial class ExtendedLightAttributes
{

}
