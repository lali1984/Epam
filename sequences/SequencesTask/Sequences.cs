using System;
using System.Collections.Generic;

namespace SequencesTask
{
    public static class Sequences
    {
        /// <summary>
        /// Find all the contiguous substrings of length length in given string of digits in the order that they appear.
        /// </summary>
        /// <param name="numbers">Source string.</param>
        /// <param name="length">Length of substring.</param>
        /// <returns>All the contiguous substrings of length n in that string in the order that they appear.</returns>
        /// <exception cref="ArgumentException">
        /// Throw if length of substring less and equals zero
        /// -or-
        /// more than length of source string
        /// - or-
        /// source string containing a non-digit character
        /// - or
        /// source string is null or empty or white space.
        /// </exception>
        public static string[] GetSubstrings(string numbers, int length)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            if (!long.TryParse(numbers, out _))
            {
                throw new ArgumentException($"{numbers}");
            }

            if (length <= 0 || length > numbers.Length)
            {
                throw new ArgumentException($"{length}");
            }

            List<string> substring = new List<string>();
            int start = 0;

            do
            {
                substring.Add(GetSubString(numbers, start, length));
                start++;
            }
            while (start <= numbers.Length - length);

            static string GetSubString(string numbers, int start, int length)
            {
                return numbers.Substring(start, length);
            }

            return substring.ToArray();
        }
    }
}
