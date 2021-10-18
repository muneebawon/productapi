using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ProductApi.Service
{
    public static class AppExtensions
    {
        #region Methods

        public static bool IsNullOrEmpty(this string input)
        {
            return string.IsNullOrEmpty(input);
        }

        public static bool IsNotNullOrEmpty(this string input)
        {
            return !string.IsNullOrEmpty(input);
        }

        public static bool IsNull(this object input)
        {
            return (input == null);
        }

        public static bool IsNotNull(this object input)
        {
            return (input != null);
        }

        public static bool Is<T>(this string input)
        {
            try
            {
                if (input.IsNullOrEmpty())
                    return false;

                TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(input);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static decimal ToDecimal(this string input)
        {
            try
            {
                if (input.IsNullOrEmpty())
                    return 0;

                return decimal.Parse(Regex.Replace(input, "[A-Za-z ]", ""));
            }
            catch
            {
                return 0;
            }
        }

        #endregion
    }
}
