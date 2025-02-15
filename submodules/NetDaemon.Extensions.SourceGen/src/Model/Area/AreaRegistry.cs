using System.Text.Json.Serialization;
using Dunet;

namespace NetDaemon.Extensions.SourceGen.Model.Area;

internal class AreaRegistry
{
    [JsonPropertyName("area_id")] public string AreaId { get; set; } = null!;

    [JsonPropertyName("name")] public string? Name { get; set; }

    [JsonPropertyName("picture")] public string? Picture { get; set; }

    [JsonPropertyName("aliases")] public List<string>? Aliases { get; set; }

    [JsonPropertyName("meta")] public AreaRegistryMeta? Meta { get; set; }
}

internal class AreaRegistryMeta
{
    [JsonPropertyName("primary_color")] public string? PrimaryColor { get; set; }

    [JsonPropertyName("secondary_color")] public string? SecondaryColor { get; set; }

    [JsonPropertyName("icon")] public string? Icon { get; set; }
}

[Union]
internal partial record AreaRegistryUnion
{
    public record AreaRegistry(AreaRegistry Area);

    public record AreaRegistryMeta(AreaRegistryMeta AreaMeta);
}