using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class NewCacheLevel
    {
        [JsonProperty("value")]
        public Enumerators.CacheLevel Value { get; set; }
    }
}