using System.ComponentModel;

namespace CloudFlare.Client.Enumerators
{
    public enum HstsMaxAge
    {
        [Description("Disable")]
        RespectExistingHeaders = 0,
        [Description("1 month")]
        OneMonth = 2592000,
        [Description("2 months")]
        TwoMonths = 5184000,
        [Description("3 months")]
        ThreeMonths = 7776000,
        [Description("4 months")]
        FourMonths = 10368000,
        [Description("5 months")]
        FiveMonths = 12960000,
        [Description("6 months")]
        SixMonths = 15552000,
        [Description("1 year")]
        OneYear = 31536000,
    }
}
