using System;

#pragma warning disable SA1611
#pragma warning disable CA1062
#pragma warning disable CA1307

namespace SearchingInStrings
{
    public static class StartsWith
    {
        /// <summary>
        /// Determines whether this string instance starts with the specified character.
        /// </summary>
        /// <returns>true if <paramref name="value"/> matches the beginning of this string; otherwise, false.</returns>
        public static bool IsStartsWith(string str, char value)
        {
            // See String.StartsWith method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.startswith
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.StartsWith(value);
        }

        /// <summary>
        /// Determines whether the beginning of this string instance matches the specified string.
        /// </summary>
        /// <returns>true if <paramref name="value"/> matches the beginning of this string; otherwise, false.</returns>
        public static bool IsStartsWith(string str, string value)
        {
            // See String.StartsWith method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.startswith
            if (str == null || value == null)
            {
                throw new ArgumentNullException($"{str}, or {value}");
            }

            return str.StartsWith(value);
        }

    /// <summary>
    /// Determines whether the beginning of this string instance matches the specified string when compared using the specified comparison option.
    /// </summary>
    /// <returns>true if <paramref name="value"/> matches the beginning of this string; otherwise, false.</returns>
        public static bool IsStartsWithStringComparison(string str, string value)
        {
            // See String.StartsWith and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.startswith
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            if (str == null || value == null)
            {
                throw new ArgumentNullException($"{str}, or {value}");
            }

            return str.StartsWith(value, StringComparison.InvariantCulture);
        }
    }
}
