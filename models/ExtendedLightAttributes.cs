using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Hammlet.NetDaemon.Models.Framework;
using NetDaemon.HassModel.Entities;
using Vogen;

namespace Hammlet.NetDaemon.Models;


public static class ValueObjectOrErrorExt
{
    public static T? ValueOrNull<T>(this ValueObjectOrError<T> @this) => @this switch
    {
        {IsSuccess:true} => @this.ValueObject,
        _ => default
    };

    public static TState? State<TState>(this IStateEntity<TState> @this)
        where TState : IParsable<TState> => TState.TryParse(@this.EntityState?.State,null,out var v) ? v : default;

}

public interface IStateEntity<out TState> where TState : IParsable<TState>
{
    public EntityState? EntityState { get; }
}
public partial record LightEntity : IStateEntity<HaState>
{
    public new HaState? State => this.State();
}
public partial record LightAttributes
{
    [JsonIgnore] public ExtendedLightAttributes? Extended { get; init; } = new ExtendedLightAttributes();
}

public partial class ExtendedLightAttributes
{

}
