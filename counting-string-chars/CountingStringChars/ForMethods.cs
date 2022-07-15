using System;

namespace CountingStringChars
{
    public static class ForMethods
    {
        public static int GetCharCount(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int letteCount = 0;

            for (int strIndex = 0; strIndex < str.Length; strIndex++)
            {
                if (char.IsLetter(str[strIndex]))
                {
                    letteCount++;
                }
            }

            return letteCount;
        }

        public static int GetUpperCharCount(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int upperCount = 0;

            for (int strIndex = 0; strIndex < str.Length; strIndex++)
            {
                if (char.IsUpper(str[strIndex]))
                {
                    upperCount++;
                }
            }

            return upperCount;
        }

        public static int GetCharCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetCharCountRecursive(str, 0);
        }

        public static int GetUpperCharCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetUpperCharCountRecursive(str, 0);
        }

        private static int GetCharCountRecursive(string str, int index)
        {
            if (index >= str.Length)
            {
                return 0;
            }

            return GetCharCountRecursive(str, index + 1) + 1;
        }

        private static int GetUpperCharCountRecursive(string str, int index)
        {
            if (index >= str.Length)
            {
                return 0;
            }

            bool isUpper = char.IsUpper(str[index]);
            int currentIncrement = isUpper ? 1 : 0;

            return GetUpperCharCountRecursive(str, index + 1) + currentIncrement;
        }
    }
}
