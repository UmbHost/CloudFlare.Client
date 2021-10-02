using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class DevelopmentModeSetting
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("modified_on")]
        public object ModifiedOn { get; set; }
        [JsonProperty("editable")]
        public bool Editable { get; set; }
    }
}