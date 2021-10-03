using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace CloudFlare.Client.Extensions
{
    public static class FriendlyEnumMethods
    {
        public static string GetDescription(this Enum value)
        {
            return ((DescriptionAttribute)Attribute.GetCustomAttribute(
                value.GetType().GetFields(BindingFlags.Public | BindingFlags.Static)
                    .Single(x => x.GetValue(null).Equals(value)),
                typeof(DescriptionAttribute)))?.Description ?? value.ToString();
        }
    }
}