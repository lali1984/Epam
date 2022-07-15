using System;

namespace LookingForChars
{
    public static class CharsCounter
    {
        public static int GetCharsCount(string str, char[] chars)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (chars == null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            if (chars.Length == 0 || str.Length == 0)
            {
                return 0;
            }

            int charsCount = 0;
            for (int strIndex = 0; strIndex < str.Length; strIndex++)
            {
                for (int charsIndex = 0; charsIndex < chars.Length; charsIndex++)
                {
                    if (chars[charsIndex] == str[strIndex])
                    {
                        charsCount++;
                    }
                }
            }

            return charsCount;
        }

        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (chars == null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            if (startIndex < 0 || startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            if (startIndex > str.Length || endIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            if (chars.Length == 0 || str.Length == 0)
            {
                return 0;
            }

            int charsCount = 0;
            int strIndex = startIndex;
            while (strIndex <= endIndex)
            {
                int charsIndex = 0;
                while (charsIndex < chars.Length)
                {
                    if (chars[charsIndex] == str[strIndex])
                    {
                        charsCount++;
                    }

                    charsIndex++;
                }

                strIndex++;
            }

            return charsCount;
        }

        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex, int limit)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (chars == null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            if (startIndex < 0 || startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            if (startIndex > str.Length || endIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            if (chars.Length == 0 || str.Length == 0)
            {
                return 0;
            }

            if (limit < 0 || limit > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(limit));
            }

            int charsCount = 0;
            int strIndex = startIndex;
            do
            {
                int charsIndex = 0;
                do
                {
                    if (chars[charsIndex] == str[strIndex])
                    {
                        charsCount++;
                    }

                    if (charsCount == limit)
                    {
                        return charsCount;
                    }

                    charsIndex++;
                }
                while (charsIndex < chars.Length);
                strIndex++;
            }
            while (strIndex <= endIndex);
            return charsCount;
        }
    }
}
