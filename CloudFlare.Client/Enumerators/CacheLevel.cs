using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CloudFlare.Client.Enumerators
{
    /// <summary>
    /// Represents the cache level
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CacheLevel
    {
        [EnumMember(Value = "aggressive")]
        Aggressive,
        [EnumMember(Value = "basic")]
        Basic,
        [EnumMember(Value = "simplified")]
        Simplified
    }
}