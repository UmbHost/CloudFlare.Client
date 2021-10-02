using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class NewBrowserCacheTtl
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
