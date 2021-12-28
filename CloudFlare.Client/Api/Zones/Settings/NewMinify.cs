using CloudFlare.Client.Enumerators;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class NewMinify
    {
        [JsonProperty("value")]
        public MinifyValue Value { get; set; }
    }

    public class MinifyValue
    {
        [JsonProperty("css")]
        public SettingsValue Css { get; set; }
        [JsonProperty("html")]
        public SettingsValue Html { get; set; }
        [JsonProperty("js")]
        public SettingsValue Js { get; set; }
    }
}
