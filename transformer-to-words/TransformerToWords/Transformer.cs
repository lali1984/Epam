using System;
using System.Globalization;
using System.Text;

namespace TransformerToWords
{
    /// <summary>
    /// Implements transformer class.
    /// </summary>
    public class Transformer
    {
        /// <summary>
        /// Transforms each element of source array into its 'word format'.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <returns>Array of 'word format' of elements of source array.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        /// <example>
        /// new[] { 2.345, -0.0d, 0.0d, 0.1d } => { "Two point three four five", "Minus zero", "Zero", "Zero point one" }.
        /// </example>
        public string[] Transform(double[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException($"{source}");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException($"{source}");
            } 

            string[] result = new string[source.Length];
            int i = 0;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-AZ");

            foreach (double number in source)
            {
                switch (number)
                {
                    case double.NaN: result[i] = "Not a Number"; i++; continue;
                    case double.PositiveInfinity: result[i] = "Positive Infinity"; i++; continue;
                    case double.NegativeInfinity: result[i] = "Negative Infinity"; i++; continue;
                    case double.Epsilon: result[i] = "Double Epsilon"; i++; continue;
                    default:
                        var words = new StringBuilder();
                        string numberStr = number.ToString(culture);
                        foreach (char c in numberStr)
                        {
                            switch (c)
                            {
                                case '1':
                                    words.Append("one ");  continue;
                                case '2':
                                    words.Append("two ");  continue;
                                case '3':
                                    words.Append("three "); continue;
                                case '4':
                                    words.Append("four ");  continue;
                                case '5':
                                    words.Append("five ");  continue;
                                case '6':
                                    words.Append("six ");  continue;
                                case '7':
                                    words.Append("seven ");  continue;
                                case '8':
                                    words.Append("eight ");  continue;
                                case '9':
                                    words.Append("nine ");  continue;
                                case '0':
                                    words.Append("zero ");  continue;
                                case '-':
                                    words.Append("minus ");  continue;
                                case '.':
                                    words.Append("point ");  continue;
                                case '+':
                                    words.Append("plus ");  continue;
                                case 'E':
                                    words.Append("E "); continue;
                            }
                        }

                        string resultStr = string.Concat(words.ToString().ToUpper(culture)[..1], words.ToString()[1..^1]);
                        result[i] = resultStr;
                        i++;
                        break;
                }
            }

            return result;
        }
    }
}
