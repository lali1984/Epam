using System;

#pragma warning disable CA1822

namespace TransformToWordsTask
{
    /// <summary>
    /// Provides transformer methods.
    /// </summary>
    public sealed class Transformer
    {
        /// <summary>
        /// Converts number's digital representation into words.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Words representation.</returns>
        public string TransformToWords(double number)
        {
            if (number == double.NegativeInfinity)
            {
                return "Negative Infinity";
            }
            else if (number == double.PositiveInfinity)
            {
                return "Positive Infinity";
            }
            else if (number == double.Epsilon)
            {
                return "Double Epsilon";
            }
            else if (double.IsNaN(number))
            {
                return "NaN";
            }

            string numberWords = string.Concat(number);
            string[] arrayWords = new string[numberWords.Length];
           
            int j = 0;
            do
            {
                arrayWords[j] = numberWords[j].ToString();
                j++;
            }
            while (j < arrayWords.Length);

            for (int i = 0; i < arrayWords.Length; i++)
            {
                arrayWords[i] = arrayWords[i] switch
                {
                    "0" => "zero",
                    "1" => "one",
                    "2" => "two",
                    "3" => "three",
                    "4" => "four",
                    "5" => "five",
                    "6" => "six",
                    "7" => "seven",
                    "8" => "eight",
                    "9" => "nine",
                    "." => "point",
                    "," => "point",
                    "+" => "plus",
                    "-" => "minus",
                    _ => arrayWords[i],
                };
            }

            numberWords = string.Join(' ', arrayWords);
            return numberWords[..1].ToUpper(System.Globalization.CultureInfo.CurrentCulture) + numberWords[1..];
        }
    }
}
