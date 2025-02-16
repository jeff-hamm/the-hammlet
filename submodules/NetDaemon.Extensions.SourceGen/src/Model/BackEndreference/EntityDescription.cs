using System.Collections.Generic;
using System.Collections.Immutable;

namespace Hammlet.Models.BackEnd
{
    [SnakeCaseEnum]
    public class EntityDescription
    {
        // Python: key: str
        public string Key { get; set; }

        // Python: device_class: str | None = None
        public string? DeviceClass { get; set; }

        // Python: entity_category: EntityCategory | None = None
        public EntityCategory? EntityCategory { get; set; }

        // Python: entity_registry_enabled_default: bool = True
        public bool EntityRegistryEnabledDefault { get; set; } = true;

        // Python: entity_registry_visible_default: bool = True
        public bool EntityRegistryVisibleDefault { get; set; } = true;

        // Python: force_update: bool = False
        public bool ForceUpdate { get; set; } = false;

        // Python: icon: str | None = None
        public string? Icon { get; set; }

        // Python: has_entity_name: bool = False
        public bool HasEntityName { get; set; } = false;

        // Python: name: str | UndefinedType | None = UNDEFINED
        public string? Name { get; set; }

        // Python: translation_key: str | None = None
        public string? TranslationKey { get; set; }

        // Python: translation_placeholders: Mapping[str, str] | None = None
        public Dictionary<string, string>? TranslationPlaceholders { get; set; }

        // Python: unit_of_measurement: str | None = None
        public string? UnitOfMeasurement { get; set; }
    }
}
