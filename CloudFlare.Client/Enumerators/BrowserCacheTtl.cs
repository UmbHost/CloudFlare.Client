using System.ComponentModel;
using Newtonsoft.Json;

namespace CloudFlare.Client.Enumerators
{
    [JsonConverter(typeof(int))]
    public enum BrowserCacheTtl
    {
        [Description("Respect Existing Headers")]
        RespectExistingHeaders = 0,
        [Description("30 minutes")]
        ThirtyMinutes = 30,
        [Description("1 hour")]
        OneHour = 60,
        [Description("2 hours")]
        TwoHours = 120,
        [Description("3 hours")]
        ThreeHours = 180,
        [Description("4 hours")]
        FourHours = 240,
        [Description("5 hours")]
        FiveHours = 300,
        [Description("8 hours")]
        EightHours = 480,
        [Description("12 hours")]
        TwelveHours = 720,
        [Description("16 hours")]
        SixteenHours = 960,
        [Description("20 hours")]
        TwentyHours = 1200,
        [Description("1 day")]
        OneDay = 1440,
        [Description("2 days")]
        TwoDays = 2880,
        [Description("3 days")]
        ThreeDays = 4320,
        [Description("4 days")]
        FourDays = 5760,
        [Description("5 days")]
        FiveDays = 7200,
        [Description("8 days")]
        EightDays = 11520,
        [Description("16 days")]
        SixteenDays = 23040,
        [Description("24 days")]
        TwentyFourDays = 34560,
        [Description("1 month")]
        OneMonth = 43800,
        [Description("2 months")]
        TwoMonths = 87600,
        [Description("6 months")]
        SixMonths = 262800,
        [Description("1 year")]
        OneYear = 525600,
    }
}
