using System;
using System.Globalization;

namespace NumeralSystems
{
    /// <summary>
    /// Converts a string representations of a numbers to its integer equivalent.
    /// </summary>
    public static class Converter
    {
        /// <summary>
        /// Converts the string representation of a positive number in the octal numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the octal numeral system.</param>
        /// <returns>A positive decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source string presents a negative number
        /// - or
        /// contains invalid symbols (non-octal alphabetic characters).
        /// Valid octal alphabetic characters: 0,1,2,3,4,5,6,7.
        /// </exception>
        public static int ParsePositiveFromOctal(this string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentNullException($"{source}");
            }

            int resoult = 0;
            int n = 1;

            foreach (char c in source)
            {
                if (!char.IsDigit(c) || int.Parse(c.ToString(), CultureInfo.InvariantCulture) >= 8)
                {
                    throw new ArgumentException($"{source}");
                }

                resoult += int.Parse(c.ToString(), CultureInfo.InvariantCulture) * (int)Math.Pow(8, source.Length - n);
                if (resoult < 0)
                {
                    throw new ArgumentException($"{source}");
                }

                n++;
            }

            return resoult;
        }

        /// <summary>
        /// Converts the string representation of a positive number in the decimal numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the decimal numeral system.</param>
        /// <returns>A positive decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source string presents a negative number
        /// - or
        /// contains invalid symbols (non-decimal alphabetic characters).
        /// Valid decimal alphabetic characters: 0,1,2,3,4,5,6,7,8,9.
        /// </exception>
        public static int ParsePositiveFromDecimal(this string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentNullException($"{source}");
            }

            int resoult = 0;
            int n = 0;

            foreach (char c in source)
            {
                if (!char.IsDigit(c))
                {
                    throw new ArgumentException($"{source}");
                }

                resoult += int.Parse(c.ToString(), CultureInfo.InvariantCulture) * (int)Math.Pow(10, source.Length - 1 - n);
                n++;
            }

            return resoult;
        }

        /// <summary>
        /// Converts the string representation of a positive number in the hex numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the hex numeral system.</param>
        /// <returns>A positive decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source string presents a negative number
        /// - or
        /// contains invalid symbols (non-hex alphabetic characters).
        /// Valid hex alphabetic characters: 0,1,2,3,4,5,6,7,8,9,A(or a),B(or b),C(or c),D(or d),E(or e),F(or f).
        /// </exception>
        public static int ParsePositiveFromHex(this string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentNullException($"{source}");
            }

            int resoult = 0;
            int n = 1;
            string hex = string.Empty;

            foreach (char c in source)
            {
                if (char.IsLetter(c))
                {
                    hex = char.ToString(char.ToUpper(c, CultureInfo.InvariantCulture));
                    hex = hex switch
                    {
                        "A" => "10",
                        "B" => "11",
                        "C" => "12",
                        "D" => "13",
                        "E" => "14",
                        "F" => "15",
                        _ => throw new ArgumentException(source)
                    };
                }
                else if (char.IsDigit(c))
                {
                    hex = c.ToString();
                }
                else
                {
                    throw new ArgumentException($"{source}");
                }

                resoult += int.Parse(hex, CultureInfo.InvariantCulture) * (int)Math.Pow(16, source.Length - n);
                
                if (resoult < 0)
                {
                    throw new ArgumentException($"{source}");
                }

                n++;
            }

            return resoult;
        }

        /// <summary>
        /// Converts the string representation of a positive number in the octal, decimal or hex numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the the octal, decimal or hex numeral system.</param>
        /// <param name="radix">The radix.</param>
        /// <returns>A positive decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source string presents a negative number
        /// - or
        /// contains invalid for given numeral system symbols
        /// -or-
        /// the radix is not equal 8, 10 or 16.
        /// </exception>
        public static int ParsePositiveByRadix(this string source, int radix)
        {
            if (radix != 8 && radix != 10 && radix != 16)
            {
                throw new ArgumentException($"{source}");
            }

            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentNullException($"{source}");
            }

            int resoult = 0;
            int n = 1;
            string hex = string.Empty;

            foreach (char c in source)
            {
                if (char.IsLetter(c))
                {
                    hex = char.ToString(char.ToUpper(c, CultureInfo.InvariantCulture));
                    hex = hex switch
                    {
                        "A" => "10",
                        "B" => "11",
                        "C" => "12",
                        "D" => "13",
                        "E" => "14",
                        "F" => "15",
                        _ => throw new ArgumentException(source)
                    };
                }
                else if ((c == '8' || c == '9') && radix == 8)
                {
                    throw new ArgumentException($"{source}");
                }
                else if (char.IsDigit(c))
                {
                    hex = c.ToString();
                }
                else
                {
                    throw new ArgumentException($"{source}");
                }

                resoult += int.Parse(hex, CultureInfo.InvariantCulture) * (int)Math.Pow(radix, source.Length - n);

                if (resoult < 0)
                {
                    throw new ArgumentException($"{source}");
                }

                n++;
            }

            return resoult;
        }

        /// <summary>
        /// Converts the string representation of a signed number in the octal, decimal or hex numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a signed number in the the octal, decimal or hex numeral system.</param>
        /// <param name="radix">The radix.</param>
        /// <returns>A signed decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source contains invalid for given numeral system symbols
        /// -or-
        /// the radix is not equal 8, 10 or 16.
        /// </exception>
        public static int ParseByRadix(this string source, int radix)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentNullException($"{source}");
            }

            int resoult = 0;
            if (radix == 10 && int.TryParse(source, out resoult))
            {
                return resoult;
            }

            if (radix != 8 && radix != 16)
            {
                throw new ArgumentException($"{source}");
            }

            int n = 1;
            string hex = string.Empty;

            foreach (char c in source)
            {
                if (char.IsLetter(c))
                {
                    hex = char.ToString(char.ToUpper(c, CultureInfo.InvariantCulture));
                    hex = hex switch
                    {
                        "A" => "10",
                        "B" => "11",
                        "C" => "12",
                        "D" => "13",
                        "E" => "14",
                        "F" => "15",
                        _ => throw new ArgumentException(source)
                    };
                }
                else if ((c == '8' || c == '9') && radix == 8)
                {
                    throw new ArgumentException($"{source}");
                }
                else if (char.IsDigit(c))
                {
                    hex = c.ToString();
                }
                else 
                {
                    throw new ArgumentException($"{source}");
                }

                resoult += int.Parse(hex, CultureInfo.InvariantCulture) * (int)Math.Pow(radix, source.Length - n);

                n++;
            }

            return resoult;
        }

        /// <summary>
        /// Converts the string representation of a positive number in the octal numeral system to its 32-bit signed integer equivalent.
        /// A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the octal numeral system.</param>
        /// <param name="value">A positive decimal value.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParsePositiveFromOctal(this string source, out int value)
        {
            value = 0;
           
            try
            {
                value = ParsePositiveFromOctal(source);
            }
            catch (ArgumentException)
            {
                return false;
            }
           
            return true;
        }

        public static bool TryParsePositiveFromDecimal(this string source, out int value)
        {
            value = 0;

            try
            {
                value = ParsePositiveFromDecimal(source);
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }

        public static bool TryParsePositiveFromHex(this string source, out int value)
        {
            value = 0;

            try
            {
                value = ParsePositiveFromHex(source);
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }

        public static bool TryParsePositiveByRadix(this string source, int radix, out int value)
        {
            if (radix != 8 && radix != 10 && radix != 16)
            {
                throw new ArgumentException($"{radix}");
            }

            value = 0;

            try
            {
                value = ParsePositiveByRadix(source, radix);
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }

        public static bool TryParseByRadix(this string source, int radix, out int value)
        {
            value = 0;

            try
            {
                value = ParseByRadix(source, radix);
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }
    }
}
