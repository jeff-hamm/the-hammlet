//using CompileTimeProxyGenerator;
//using Hammlet.Extensions;
//using Hammlet.NetDaemon.Extensions;
//using Hammlet.NetDaemon.Models;

//namespace NetDaemon.HassModel.Entities;

//public partial interface ITestInterface
//{
//    public int Value { get; }
//}

//[Proxy(typeof(EntityState<MediaPlayerAttributes>), ConvertFrom = ConversionType.Implicit, ConvertTo = ConversionType.Implicit)]
//public partial record MediaPlayerState : EntityState
//{
//    public static MediaPlayerState? FromState(EntityState<MediaPlayerAttributes>? state) => state != null ? new MediaPlayerState(state) : null;
//    public static MediaPlayerState? FromState(EntityState? state) => state != null ? new MediaPlayerState(new EntityState<MediaPlayerAttributes>(state)) : null;
//    public new MediaPlayerAttributes? Attributes => _inner.Attributes;


//    public new MediaPlayerStates State =>  this._inner.ParseState<MediaPlayerStates>() ?? MediaPlayerStates.Unknown;
//}