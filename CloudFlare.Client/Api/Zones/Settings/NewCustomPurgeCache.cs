using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class NewCustomPurgeCache
    {
        [JsonProperty("files")]
        public string[] Files { get; set; }
    }
}
