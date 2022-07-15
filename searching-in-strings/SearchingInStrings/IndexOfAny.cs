using System;

#pragma warning disable SA1611
#pragma warning disable CA1062
#pragma warning disable CA1307

namespace SearchingInStrings
{
    public static class IndexOfAny
    {
        /// <summary>
        /// Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters.
        /// </summary>
        /// <returns>The zero-based index position of the first occurrence in this instance where any character in <paramref name="anyOf"/> was found; -1 if no character in <paramref name="anyOf"/> was found.</returns>
        public static int GetIndexOfAnyChar(string str, char[] anyOf)
        {
            // See String.IndexOfAny method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.indexofany
            return str.IndexOfAny(anyOf);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters. The search starts at a specified character position.
        /// </summary>
        /// <returns>The zero-based index position of the first occurrence in this instance where any character in <paramref name="anyOf"/> was found; -1 if no character in <paramref name="anyOf"/> was found.</returns>
        public static int GetIndexOfAnyChar(string str, char[] anyOf, int startIndex)
        {
            // See String.IndexOfAny method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.indexofany
            return str.IndexOfAny(anyOf, startIndex);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters. The search starts at a specified character position and examines a specified number of character positions.
        /// </summary>
        /// <returns>The zero-based index position of the first occurrence in this instance where any character in anyOf was found; -1 if no character in anyOf was found.</returns>
        public static int GetIndexOfAnyChar(string str, char[] anyOf, int startIndex, int count)
        {
            // See String.IndexOfAny method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.indexofany
            return str.IndexOfAny(anyOf, startIndex, count);
        }
    }
}
