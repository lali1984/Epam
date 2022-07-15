using System;

#pragma warning disable SA1611
#pragma warning disable CA1062
#pragma warning disable CA1307

namespace SearchingInStrings
{
    public static class LastIndexOfAny
    {
        /// <summary>
        /// Reports the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array.
        /// </summary>
        /// <returns>The index position of the last occurrence in this instance where any character in <paramref value="anyOf" />was found; -1 if no character in <paramref value="anyOf" />was found or if the current instance equals Empty.</returns>
        public static int GetLastIndexOfAny(string str, char[] anyOf)
        {
            // See String.IndexOfAny method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexofany
            return str.LastIndexOfAny(anyOf);
        }

        /// <summary>
        /// Reports the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array. The search starts at a specified character position and proceeds backward toward the beginning of the string.
        /// </summary>
        /// <returns>The index position of the last occurrence in this instance where any character in <paramref value="anyOf" />was found; -1 if no character in <paramref value="anyOf" />was found or if the current instance equals Empty.</returns>
        public static int GetLastIndexOfAny(string str, char[] anyOf, int startIndex)
        {
            // See String.IndexOfAny method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexofany
            return str.LastIndexOfAny(anyOf, startIndex);
        }

        /// <summary>
        /// Reports the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array. The search starts at a specified character position and proceeds backward toward the beginning of the string for a specified number of character positions.
        /// </summary>
        /// <returns>The index position of the last occurrence in this instance where any character in <paramref value="anyOf" />was found; -1 if no character in <paramref value="anyOf" />was found or if the current instance equals Empty.</returns>
        public static int GetLastIndexOfAny(string str, char[] anyOf, int startIndex, int count)
        {
            // See String.IndexOfAny method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexofany
            return str.LastIndexOfAny(anyOf, startIndex, count);
        }
    }
}
