using System;

#pragma warning disable SA1611
#pragma warning disable CA1062
#pragma warning disable CA1307

namespace SearchingInStrings
{
    public static class IndexOf
    {
        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified Unicode character in this string.
        /// </summary>
        /// <returns>The zero-based index position of <see cref="value"/> if that character is found, or -1 if it is not.</returns>
        public static int GetIndexOfChar(string str, char value)
        {
            // See String.IndexOf method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.IndexOf(value);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified Unicode character in this string. A parameter specifies the type of search to use for the specified character.
        /// </summary>
        /// <returns>The zero-based index position of <see cref="value"/> if that character is found, or -1 if it is not.</returns>
        public static int GetIndexOfCharInvariantCultureIgnoreCase(string str, char value)
        {
            // See String.IndexOf and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.IndexOf(value, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified Unicode character in this string. A parameter specifies the type of search to use for the specified character.
        /// </summary>
        /// <returns>The zero-based index position of <see cref="value"/> if that character is found, or -1 if it is not.</returns>
        public static int GetIndexOfCharWithStringComparison(string str, char value)
        {
            // See String.IndexOf and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.IndexOf(value, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified Unicode character in this string. The search starts at a specified character position.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> from the start of the string if that character is found, or -1 if it is not.</returns>
        public static int GetIndexOfChar(string str, char value, int startIndex)
        {
            // See String.IndexOf method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.IndexOf(value, startIndex);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified character in this instance. The search starts at a specified character position and examines a specified number of character positions.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> from the start of the string if that character is found, or -1 if it is not.</returns>
        public static int GetIndexOfChar(string str, char value, int startIndex, int count)
        {
            // See String.IndexOf method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.IndexOf(value, startIndex, count);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in this instance.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> if that string is found, or -1 if it is not. If value is <see cref="string.Empty"/>, the return <paramref name="value"/> is 0.</returns>
        public static int GetIndexOfString(string str, string value)
        {
            // See String.IndexOf method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.IndexOf(value);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in the current String object. A parameter specifies the type of search to use for the specified string.
        /// </summary>
        /// <returns>The index position of the <paramref name="value"/> parameter if that string is found, or -1 if it is not. If <paramref name="value"/> is <see cref="string.Empty"/>, the return value is 0.</returns>
        public static int GetIndexOfStringOrdinal(string str, string value)
        {
            // See String.IndexOf and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.IndexOf(value, StringComparison.Ordinal);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in the current String object. A parameter specifies the type of search to use for the specified string.
        /// </summary>
        /// <returns>The index position of the <paramref name="value"/> parameter if that string is found, or -1 if it is not. If <paramref name="value"/> is <see cref="string.Empty"/>, the return value is 0.</returns>
        public static int GetIndexOfStringWithStringComparison(string str, string value)
        {
            // See String.IndexOf and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.IndexOf(value, StringComparison.InvariantCulture);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in this instance. The search starts at a specified character position.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> from the start of the current instance if that string is found, or -1 if it is not. If value is Empty, the return <paramref name="value"/> is <paramref name="startIndex"/>.</returns>
        public static int GetIndexOfString(string str, string value, int startIndex)
        {
            // See String.IndexOf method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.IndexOf(value, startIndex);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in the current String object. Parameters specify the starting search position in the current string and the type of search to use for the specified string.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> from the start of the current instance if that string is found, or -1 if it is not. If value is Empty, the return <paramref name="value"/> is <paramref name="startIndex"/>.</returns>
        public static int GetIndexOfStringCurrentCultureIgnoreCase(string str, string value, int startIndex)
        {
            // See String.IndexOf and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.IndexOf(value, startIndex, StringComparison.CurrentCultureIgnoreCase);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in the current String object. Parameters specify the starting search position in the current string and the type of search to use for the specified string.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> from the start of the current instance if that string is found, or -1 if it is not. If value is Empty, the return <paramref name="value"/> is <paramref name="startIndex"/>.</returns>
        public static int GetIndexOfStringWithStringComparison(string str, string value, int startIndex)
        {
            // See String.IndexOf and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.IndexOf(value, startIndex, StringComparison.CurrentCulture);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in this instance. The search starts at a specified character position and examines a specified number of character positions.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> from the start of the current instance if that string is found, or -1 if it is not. If value is Empty, the return <paramref name="value"/> is <paramref name="startIndex"/>.</returns>
        public static int GetIndexOfString(string str, string value, int startIndex, int count)
        {
            // See String.IndexOf method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.IndexOf(value, startIndex, count);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in the current String object. Parameters specify the starting search position in the current string, the number of characters in the current string to search, and the type of search to use for the specified string.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> from the start of the current instance if that string is found, or -1 if it is not. If value is Empty, the return <paramref name="value"/> is <paramref name="startIndex"/>.</returns>
        public static int GetIndexOfStringInvariantCulture(string str, string value, int startIndex, int count)
        {
            // See String.IndexOf and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.IndexOf(value, startIndex, count, StringComparison.InvariantCulture);
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in the current String object. Parameters specify the starting search position in the current string, the number of characters in the current string to search, and the type of search to use for the specified string.
        /// </summary>
        /// <returns>The zero-based index position of <paramref name="value"/> from the start of the current instance if that string is found, or -1 if it is not. If value is Empty, the return <paramref name="value"/> is <paramref name="startIndex"/>.</returns>
        public static int GetIndexOfStringWithStringComparison(string str, string value, int startIndex, int count)
        {
            // See String.IndexOf and StringComparison documentation pages:
            // * https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof
            // * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.IndexOf(value, startIndex, count, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
