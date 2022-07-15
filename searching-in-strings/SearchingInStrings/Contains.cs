using System;

#pragma warning disable SA1611
#pragma warning disable CA1062
#pragma warning disable CA1307

namespace SearchingInStrings
{
    public static class Contains
    {
        /// <summary>
        /// Returns a value indicating whether a specified character occurs within this string.
        /// </summary>
        /// <returns>true if the <paramref name="value"/> parameter occurs within this string; otherwise, false.</returns>
        public static bool IsContainsChar(string str, char value)
        {
            // See String.Contains method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.contains
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Contains(value);
        }

        /// <summary>
        /// Returns a value indicating whether a specified character occurs within this string, using the specified comparison rules.
        /// </summary>
        /// <returns>true if the <paramref name="value"/> parameter occurs within this string; otherwise, false.</returns>
        public static bool IsContainsCharWithStringComparison(string str, char value)
        {
            // See String.Contains and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.contains
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Contains(value, StringComparison.InvariantCulture);
        }

        /// <summary>
        /// Returns a value indicating whether a specified substring occurs within this string.
        /// </summary>
        /// <returns>true if the <paramref name="value"/> parameter occurs within this string, or if <paramref name="value"/> is the <see cref="string.Empty"/>; otherwise, false.</returns>
        public static bool IsContainsString(string str, string value)
        {
            // See String.Contains method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.contains
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Contains(value);
        }

        /// <summary>
        /// Returns a value indicating whether a specified string occurs within this string, using the specified comparison rules.
        /// </summary>
        /// <returns>true if the <paramref name="value"/> parameter occurs within this string, or if <paramref name="value"/> is the <see cref="string.Empty"/>; otherwise, false.</returns>
        public static bool IsContainsStringWithStringComparison(string str, string value)
        {
            // See String.Contains and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.contains
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Contains(value, StringComparison.InvariantCulture);
        }
    }
}
