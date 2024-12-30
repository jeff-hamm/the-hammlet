using System.Collections;
using System.Text.Json;
using Hammlet.NetDaemon.Models;
using HassModel;
using NetDaemon.HassModel.Entities;

namespace Hammlet.NetDaemon.apps.Media;

/// <summary>
///     Showcase using the new HassModel API and turn on light on movement
/// </summary>
[NetDaemonApp]
public class PlaylistTrigger
{
    public PlaylistTrigger(IHaContext ha, SelectEntities entities, MediaPlayerEntities mediaPLayers, SensorEntities sensors, ILogger<PlaylistTrigger> logger)
    {

        entities.YtubeMusicPlayerPlaylist.StateChanges().Subscribe(e =>
        {
            if (e.New?.State is not {} playListName)
            {
                if (e.Old?.State == null) return;
                if (!mediaPLayers.YtubeMusicPlayer.IsOn()) return;
                mediaPLayers.YtubeMusicPlayer.MediaStop();
                logger.LogDebug("Changed playlist to empty, stopping playlist");
                return;
            }
            var pl = sensors.YtubeMusicPlayerExtra.Attributes?.Playlists;
            if (pl is not JsonElement { ValueKind: JsonValueKind.Object } obj)
            {
                logger.LogError("Unexpected playlist attributes type {playlistType}",pl?.GetType()?.ToString() ?? "Null");
                return;
            }
            if (!obj.TryGetProperty(playListName, out var propertyValue))
            {
                logger.LogError("Could not find playlist {playList} in YtubeMusicPlayerExtra", playListName);
                return;
            }

            if (propertyValue.ValueKind != JsonValueKind.String || propertyValue.GetString() is not {} val) 
            {
                logger.LogError("Unexpected property ValueKind {ValueKind} {Value} in YtubeMusicPlayerExtra", propertyValue.ValueKind, propertyValue);
                return;

            }
            mediaPLayers.YtubeMusicPlayer.PlayMedia(val,"playlist");
        });
    }
}
