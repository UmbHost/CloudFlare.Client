using System;
using CloudFlare.Client.Enumerators;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class SecurityHeaderHsts
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("modified_on")]
        public DateTime? ModifiedOn { get; set; }
        [JsonProperty("value")]
        public SecurityHeaderHstsValue Value { get; set; }
        [JsonProperty("editable")]
        public bool Editable { get; set; }
    }

    public class SecurityHeaderHstsValue
    {
        [JsonProperty("strict_transport_security")]
        public StrictTransportSecurity StrictTransportSecurity { get; set; }
    }

    public class StrictTransportSecurity
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("max_age")]
        public HstsMaxAge MaxAge { get; set; }
        [JsonProperty("include_subdomains")]
        public bool IncludeSubdomains { get; set; }
        [JsonProperty("preload")]
        public bool Preload { get; set; }
        [JsonProperty("nosniff")]
        public bool Nosniff { get; set; }
    }
}
