using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class NewBrowserCacheTtl
    {
        [JsonProperty("value")]
        public Enumerators.BrowserCacheTtl Value { get; set; }
    }
}
