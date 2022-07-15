using System;

namespace CountingStringChars
{
    public static class WhileMethods
    {
        public static int GetSpaceCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int strIndex = 0;
            int count = 0;
            while (strIndex < str.Length)
            {
                if (char.IsWhiteSpace(str[strIndex]))
                {
                    count++;
                }

                strIndex++;
            }

            return count;
        }

        public static int GetPunctuationCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int strIndex = 0;
            int count = 0;
            while (strIndex < str.Length)
            {
                if (char.IsPunctuation(str[strIndex]))
                {
                    count++;
                }

                strIndex++;
            }

            return count;
        }

        public static int GetSpaceCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int result = GetSpaceCountRecursive(str[1..]) + (char.IsWhiteSpace(str[0]) ? 1 : 0);

            return result;
        }

        public static int GetPunctuationCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            bool isPunctuation = char.IsPunctuation(str[0]);
            int currentIncrement = isPunctuation ? 1 : 0;
            int result = GetPunctuationCountRecursive(str[1..]) + currentIncrement;

            return result;
        }
    }
}
