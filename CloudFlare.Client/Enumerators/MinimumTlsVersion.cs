using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CloudFlare.Client.Enumerators
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MinimumTlsVersion
    {
        [Description("TLS 1.0")]
        [EnumMember(Value = "1.0")]
        Tls10,
        [Description("TLS 1.1")]
        [EnumMember(Value = "1.1")]
        Tls11,
        [Description("TLS 1.2")]
        [EnumMember(Value = "1.2")]
        Tls12,
        [Description("TLS 1.3")]
        [EnumMember(Value = "1.3")]
        Tls13
    }
}
