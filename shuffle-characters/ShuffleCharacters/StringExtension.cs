using System;
using System.Collections.Generic;
using System.Text;

namespace ShuffleCharacters
{
    public static class StringExtension
    {
        public static string ShuffleChars(string source, int count)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentException("Source is null.");
            }

            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentException("Source is WhiteSpaced.");
            }

            if (count < 0)
            {
                throw new ArgumentException("Count of iteration is less than 0.");
            }

            if (source.Length <= 1)
            {
                return source;
            }

            StringBuilder left = new StringBuilder();
            StringBuilder right = new StringBuilder();
            string source2 = source;

            for (int i = 1; i <= count; i++)
            {
                for (int j = 0; j < source.Length; j++)
                {
                    if (j == 0 || j % 2 == 0)
                    {
                        left.Append(source2[j]);
                    }
                    else
                    {
                        right.Append(source2[j]);
                    }
                }

                source2 = string.Concat(left, right);
                left.Clear();
                right.Clear();
                if (source2 == source)
                {
                    count %= i;
                    i = 0;
                }
            }

            return source2;
        }
    }
}
