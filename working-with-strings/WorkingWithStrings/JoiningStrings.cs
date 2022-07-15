using System;
using System.Collections.Generic;

namespace WorkingWithStrings
{
    public static class JoiningStrings
    {
        public static string GetCommaSeparatedString(string[] values)
        {
            return string.Join(',', values);
        }

        public static string GetColonSeparatedString(string[] values)
        {
            return string.Join(':', values);
        }

        public static string GetCommaSeparatedStringWithoutFirstElement(string[] values)
        {
            return string.Join(',', values[1..]);
        }

        public static string GetHyphenSeparatedStringWithoutFirstAndLastElements(string[] values)
        {
            return string.Join('-', values[1..^1]);
        }

        public static string GetPlusSeparatedString(IEnumerable<string> values)
        {
            return string.Join('+', values);
        }

        public static string GetBackslashSeparatedString(IEnumerable<object> values)
        {
            return string.Join('\\', values);
        }

        public static string GetStringSeparatedString(object[] values)
        {
            return string.Join("], [", values);
        }

        public static string GetStringSeparatedStringForLastThreeElements(string separator, string[] values)
        {
                return string.Join(separator, values[^3..]);
        }
    }
}
