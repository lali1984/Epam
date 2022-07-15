using System;

namespace WorkingWithStrings
{
    public static class SplittingStrings
    {
        public static string[] SplitCommaSeparatedString(string str)
        {
            return str.Split(',');
        }

        public static string[] SplitColonSeparatedString(string str)
        {
            return str.Split(':');
        }

        public static string[] SplitCommaSeparatedStringMaxTwoElements(string str)
        {
            return str.Split(',', 2);
        }

        public static string[] SplitColonSeparatedStringMaxThreeElements(string str)
        {
            return str.Split(':', 3);
        }

        public static string[] SplitHyphenSeparatedStringMaxThreeElementsRemoveEmptyStrings(string str)
        {
            return str.Split('-', 3, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string[] SplitColonAndCommaSeparatedStringMaxFourElementsRemoveEmptyStrings(string str)
        {
            string[] separetors = new string[4] { ":", ",", ":,", ",:" };
            return str.Split(separetors, 4, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string[] GetOnlyWords(string str)
        {
            string[] separretors = new string[6] { ": ", " ", ",", "-", ".\t", "!" };
            return str.Split(separretors, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string[] GetDataFromCsvLine(string str)
        {
            char[] separretors = new char[2] { ' ', ',' };
            return str.Split(separretors, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
