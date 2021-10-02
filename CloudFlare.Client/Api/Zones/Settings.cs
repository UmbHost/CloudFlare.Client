using System;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones
{
    public class Settings
    {
        /// <summary>
        /// Zone identifier tag
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("modified_on")]
        public DateTime ModifiedOn { get; set; }

        [JsonProperty("time_remaining")]
        public int TimeRemaining { get; set; }
    }
}
