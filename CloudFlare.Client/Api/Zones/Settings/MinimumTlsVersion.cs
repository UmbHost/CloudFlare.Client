using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class MinimumTlsVersion
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("value")]
        public Enumerators.MinimumTlsVersion Value { get; set; }
        [JsonProperty("modified_on")]
        public object ModifiedOn { get; set; }
        [JsonProperty("editable")]
        public bool Editable { get; set; }
    }
}
