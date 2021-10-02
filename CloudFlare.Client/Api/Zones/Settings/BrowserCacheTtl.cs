using System;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class BrowserCacheTtl
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("value")]
        public int Value { get; set; }
        [JsonProperty("modified_on")]
        public DateTime? ModifiedOn { get; set; }
        [JsonProperty("editable")]
        public bool Editable { get; set; }
    }
}
