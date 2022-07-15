using System;

#pragma warning disable SA1611
#pragma warning disable CA1062
#pragma warning disable CA1307

namespace SearchingInStrings
{
    public static class EndsWith
    {
        /// <summary>
        /// Determines whether the end of this string instance matches the specified character.
        /// </summary>
        /// <returns>true if the <paramref name="value"/> parameter matches the end of this string; otherwise, false.</returns>
        public static bool IsEndsWith(string str, char value)
        {
            // See String.EndsWith method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.endswith
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.EndsWith(value);
        }

        /// <summary>
        /// Determines whether the end of this string instance matches the specified string.
        /// </summary>
        /// <returns>true if the <paramref name="value"/> parameter matches the end of this string; otherwise, false.</returns>
        public static bool IsEndsWith(string str, string value)
        {
            // See String.EndsWith method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.endswith
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.EndsWith(value);
        }

        /// <summary>
        /// Determines whether the end of this string instance matches the specified string when compared using the specified comparison option.
        /// </summary>
        /// <returns>true if the <paramref name="value"/> parameter matches the end of this string; otherwise, false.</returns>
        public static bool IsEndsWithStringComparison(string str, string value)
        {
            // See String.EndsWith and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.endswith
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.EndsWith(value, StringComparison.InvariantCulture);
        }
    }
}
