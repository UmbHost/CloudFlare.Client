using CloudFlare.Client.Enumerators;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class NewDevelopmentModeSetting
    {
        [JsonProperty("value")]
        public DevelopmentModeStatus Value { get; set; }
    }
}