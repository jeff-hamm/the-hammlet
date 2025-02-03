using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;

public static class EnumExtensions
{
    private static readonly ConcurrentDictionary<Enum, string> nameDictionary = new();
    public static string GetJsonName(this Enum enumValue)
    {
        return nameDictionary.GetOrAdd(enumValue, _ =>
        enumValue.GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<JsonStringEnumMemberNameAttribute>()
            ?.Name?? enumValue.ToString());
    }
}