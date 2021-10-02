using System;
using CloudFlare.Client.Enumerators;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class Mirage
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("value")]
        public SettingsValue Value { get; set; }
        [JsonProperty("modified_on")]
        public DateTime? ModifiedOn { get; set; }
        [JsonProperty("editable")]
        public bool Editable { get; set; }
    }
}
