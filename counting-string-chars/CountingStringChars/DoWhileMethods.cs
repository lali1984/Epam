using System;

namespace CountingStringChars
{
    public static class DoWhileMethods
    {
        public static int GetDigitCount(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (str.Length == 0)
            {
                return 0;
            }

            int digitCount = 0;
            int strIndex = 0;
            do
            {
                if (char.IsDigit(str[strIndex]))
                {
                    digitCount++;
                }

                strIndex++;
            }
            while (strIndex < str.Length);
            return digitCount;
        }

        public static int GetLetterCount(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (str.Length == 0)
            {
                return 0;
            }

            int letterCount = 0;
            int number = 0;
            do
            {
                if (char.IsLetter(str[number]))
                {
                    letterCount++;
                }

                number++;
            }
            while (number < str.Length);
            return letterCount;
        }

        public static int GetDigitCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetDigitCountRecursive(str, str.Length, 0);
        }

        public static int GetLetterCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetLetterCountRecursive(str, str.Length, 0);
        }

        private static int GetDigitCountRecursive(string str, int charsLeft, int counter)
        {
            if (charsLeft > 0)
            {
                return GetDigitCountRecursive(str, charsLeft - 1, char.IsDigit(str[^charsLeft]) ? counter + 1 : counter);
            }

            return counter;
        }

        private static int GetLetterCountRecursive(string str, int charsLeft, int counter)
        {
            if (charsLeft > 0)
            {
                return GetLetterCountRecursive(str, charsLeft - 1, char.IsLetter(str[^charsLeft]) ? counter + 1 : counter);
            }

            return counter;
        }
    }
}
