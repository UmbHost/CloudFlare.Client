using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class NewSecurityHeaderHsts
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("max_age")]
        public int MaxAge { get; set; }
        [JsonProperty("include_subdomains")]
        public bool IncludeSubdomains { get; set; }
        [JsonProperty("preload")]
        public bool Preload { get; set; }
        [JsonProperty("nosniff")]
        public bool Nosniff { get; set; }
    }
}
