using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class CustomPurgeCache
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
