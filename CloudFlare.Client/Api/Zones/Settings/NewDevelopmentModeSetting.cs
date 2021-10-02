using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class NewDevelopmentModeSetting
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}