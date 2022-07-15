using System;

#pragma warning disable SA1611
#pragma warning disable CA1062
#pragma warning disable CA1307

namespace SearchingInStrings
{
    public static class LastIndexOf
    {
        /// <summary>
        /// Reports the zero-based index position of the last occurrence of a specified Unicode character within this instance.
        /// </summary>
        /// <returns>The zero-based index position of <see cref="value"/> if that character is found, or -1 if it is not.</returns>
        public static int GetLastIndexOfChar(string str, char value)
        {
            // See String.LastIndexOf method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexof
            return str.LastIndexOf(value);
        }

        /// <summary>
        /// Reports the zero-based index position of the last occurrence of a specified Unicode character within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> if that character is found, or -1 if it is not found or if the current instance equals <see cref="string.Empty"/>.</returns>
        public static int GetLastIndexOfChar(string str, char value, int startIndex)
        {
            // See String.LastIndexOf method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexof
            return str.LastIndexOf(value, startIndex);
        }

        /// <summary>
        /// Reports the zero-based index position of the last occurrence of the specified Unicode character in a substring within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string for a specified number of character positions.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> if that character is found, or -1 if it is not found or if the current instance equals <see cref="string.Empty"/>.</returns>
        public static int GetLastIndexOfChar(string str, char value, int startIndex, int count)
        {
            // See String.LastIndexOf method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexof
            return str.LastIndexOf(value, startIndex, count);
        }

        /// <summary>
        /// Reports the zero-based index position of the last occurrence of a specified string within this instance.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> if that string is found, or -1 if it is not. If value is <see cref="string.Empty"/>, the return <paramref name="value"/> is 0.</returns>
        public static int GetLastIndexOfString(string str, string value)
        {
            // See String.LastIndexOf method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexof
            return str.LastIndexOf(value);
        }

        /// <summary>
        /// Reports the zero-based index of the last occurrence of a specified string within the current String object. A parameter specifies the type of search to use for the specified string.
        /// </summary>
        /// <returns>The index position of the <paramref name="value"/> parameter if that string is found, or -1 if it is not. If <paramref name="value"/> is Empty, the return value is 0.</returns>
        public static int GetLastIndexOfStringOrdinal(string str, string value)
        {
            // See String.LastIndexOf and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexof
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            return str.LastIndexOf(value, StringComparison.Ordinal);
        }

        /// <summary>
        /// Reports the zero-based index of the last occurrence of a specified string within the current String object. A parameter specifies the type of search to use for the specified string.
        /// </summary>
        /// <returns>The index position of the <paramref name="value"/> parameter if that string is found, or -1 if it is not. If <paramref name="value"/> is Empty, the return value is 0.</returns>
        public static int GetLastIndexOfStringWithStringComparison(string str, string value)
        {
            // See String.LastIndexOf and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexof
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            return str.LastIndexOf(value, StringComparison.InvariantCulture);
        }

        /// <summary>
        /// Reports the zero-based index position of the last occurrence of a specified string within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> from the start of the current instance if that string is found, or -1 if it is not. If value is <see cref="string.Empty"/>, the return <paramref name="value"/> is <paramref name="startIndex"/>.</returns>
        public static int GetLastIndexOfString(string str, string value, int startIndex)
        {
            // See String.LastIndexOf method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexof
            return str.LastIndexOf(value, startIndex);
        }

        /// <summary>
        /// Reports the zero-based index of the last occurrence of a specified string within the current String object. The search starts at a specified character position and proceeds backward toward the beginning of the string. A parameter specifies the type of comparison to perform when searching for the specified string.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> from the start of the current instance if that string is found, or -1 if it is not. If value is <see cref="string.Empty"/>, the return <paramref name="value"/> is <paramref name="startIndex"/>.</returns>
        public static int GetLastIndexOfStringCurrentCultureIgnoreCase(string str, string value, int startIndex)
        {
            // See String.LastIndexOf and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexof
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            return str.LastIndexOf(value, startIndex, StringComparison.CurrentCultureIgnoreCase);
        }

        /// <summary>
        /// Reports the zero-based index of the last occurrence of a specified string within the current String object. The search starts at a specified character position and proceeds backward toward the beginning of the string. A parameter specifies the type of comparison to perform when searching for the specified string.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> from the start of the current instance if that string is found, or -1 if it is not. If value is <see cref="string.Empty"/>, the return <paramref name="value"/> is <paramref name="startIndex"/>.</returns>
        public static int GetLastIndexOfStringWithStringComparison(string str, string value, int startIndex)
        {
            // See String.LastIndexOf and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexof
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            return str.LastIndexOf(value, startIndex, StringComparison.CurrentCulture);
        }

        /// <summary>
        /// Reports the zero-based index position of the last occurrence of a specified string within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string for a specified number of character positions.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> from the start of the current instance if that string is found, or -1 if it is not. If value is <see cref="string.Empty"/>, the return <paramref name="value"/> is <paramref name="startIndex"/>.</returns>
        public static int GetLastIndexOfString(string str, string value, int startIndex, int count)
        {
            // See String.LastIndexOf method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexof
            return str.LastIndexOf(value, startIndex, count);
        }

        /// <summary>
        /// Reports the zero-based index of the last occurrence of the specified string in the current String object. Parameters specify the starting search position in the current string, the number of characters in the current string to search, and the type of search to use for the specified string.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> from the end of the current instance if that string is found, or -1 if it is not. If value is <see cref="string.Empty"/>, the return <paramref name="value"/> is <paramref name="startIndex"/>.</returns>
        public static int GetLastIndexOfStringInvariantCulture(string str, string value, int startIndex, int count)
        {
            // See String.LastIndexOf and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexof
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            return str.LastIndexOf(value, startIndex, count, StringComparison.InvariantCulture);
        }

        /// <summary>
        /// Reports the zero-based index of the last occurrence of the specified string in the current String object. Parameters specify the starting search position in the current string, the number of characters in the current string to search, and the type of search to use for the specified string.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> from the end of the current instance if that string is found, or -1 if it is not. If value is <see cref="string.Empty"/>, the return <paramref name="value"/> is <paramref name="startIndex"/>.</returns>
        public static int GetLastIndexOfStringWithStringComparison(string str, string value, int startIndex, int count)
        {
            // See String.LastIndexOf and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexof
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            return str.LastIndexOf(value, startIndex, count, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
