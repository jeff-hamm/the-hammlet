using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hammlet.Models.BackEnd
{
    [AttributeUsage(AttributeTargets.Enum)]
    public class SnakeCaseEnumAttribute : JsonConverterAttribute
    {
        public SnakeCaseEnumAttribute() : base(typeof(HomeAssistantStringEnumConverter))
        {
        }
    }
}
