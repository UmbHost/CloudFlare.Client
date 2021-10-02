using CloudFlare.Client.Enumerators;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class Minify
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("value")]
        public MinifyAsset Value { get; set; }
        [JsonProperty("modified_on")]
        public object ModifiedOn { get; set; }
        [JsonProperty("editable")]
        public bool Editable { get; set; }
    }

    public class MinifyAsset
    {
        [JsonProperty("css")]
        public SettingsValue Css { get; set; }
        [JsonProperty("html")]
        public SettingsValue Html { get; set; }
        [JsonProperty("js")]
        public SettingsValue Js { get; set; }
    }
}
