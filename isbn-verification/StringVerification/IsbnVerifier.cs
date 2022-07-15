using System;
using System.Collections.Generic;
using System.Linq;

namespace StringVerification
{
    public static class IsbnVerifier
    {
        /// <summary>
        /// Verifies if the string representation of number is a valid ISBN-10 identification number of book.
        /// </summary>
        /// <param name="number">The string representation of book's number.</param>
        /// <returns>true if number is a valid ISBN-10 identification number of book, false otherwise.</returns>
        /// <exception cref="ArgumentException">Thrown if number is null or empty or whitespace.</exception>
        public static bool IsValid(string number)
        {
            if (string.IsNullOrWhiteSpace(number)) 
            {
                throw new ArgumentException("number is Null, Empty or WhiteSpace");
            }

            if (number.Length < 10 || number.Length > 13)
            {
                return false;
            }

            int j = 10;
            int resoult = 0;
            string[] numberStr = new string[10];

            if (!char.IsDigit(number[0]) && (!char.IsDigit(number[^1]) || number[^1] != 'X'))
            {
                return false;
            }
            else
            {
                numberStr[0] = number[..1];
                numberStr[^1] = number[^1] switch
                {
                    'X' => "10",
                    _ => number[^1..],
                };
            }

            if (number.Length == 13)
            {
                number = number[2..^2];
            }
            else
            {
                number = number[1..^1].Trim(new char[] { '-', '-' });
            }

            if (number[3] == '-')
            {
                number = number.Remove(3, 1);
            }

            if (number.Length != 8)
            {
                return false;
            }
            else
            {
                int index = 1;
                foreach (char c in number)
                {
                    numberStr[index] = c.ToString();
                    index++;
                }
            }

            foreach (string s in numberStr)
            {
                if (int.TryParse(s, out int num))
                {
                    resoult += num * j;
                }
                else
                {
                    return false;
                }

                j--;
            }

            return (resoult % 11) switch
            {
                0 => true,
                _ => false,
            };
        }
    }
}
