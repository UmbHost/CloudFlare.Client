using CloudFlare.Client.Enumerators;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class NewEarlyHints
    {
        [JsonProperty("value")]
        public SettingsValue Value { get; set; }
    }
}