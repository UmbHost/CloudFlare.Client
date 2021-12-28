using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class NewSecurityHeaderHsts
    {
        [JsonProperty("value")]
        public NewStrictTransportSecurity Value { get; set; }
    }

    public class NewStrictTransportSecurity
    {
        [JsonProperty("strict_transport_security")]
        public NewStrictTransportSecurityValues StrictTransportSecurity { get; set; }
    }

    public class NewStrictTransportSecurityValues
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
