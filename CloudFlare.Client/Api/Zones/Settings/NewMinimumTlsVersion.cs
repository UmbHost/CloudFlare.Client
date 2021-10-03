using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Settings
{
    public class NewMinimumTlsVersion
    {
        [JsonProperty("value")]
        public Enumerators.MinimumTlsVersion Value { get; set; }
    }
}
