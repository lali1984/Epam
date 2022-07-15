using System;
using System.Collections.Generic;

namespace SearchByPatternInText
{
    public static class Searcher
    {
        /// <summary>
        /// Searches the pattern string inside the text and collects information about all hit positions in the order they appear.
        /// </summary>
        /// <param name="text">Source text.</param>
        /// <param name="pattern">Source pattern text.</param>
        /// <param name="overlap">Flag to overlap:
        /// if overlap flag is true collect every position overlapping included,
        /// if false no overlapping is allowed (next search behind).</param>
        /// <returns>List of positions of occurrence of the pattern string in the text, if any and empty otherwise.</returns>
        /// <exception cref="ArgumentException">Thrown if text or pattern is null.</exception>
        public static int[] SearchPatternString(this string text, string pattern, bool overlap)
        {
            if (pattern == null || text == null)
            {
                throw new ArgumentException($"{pattern}, or {text} is null.");
            }

            int[] result;
            List<int> patternsIndex = new List<int>();

            if (overlap)
            {
                result = SearchPatternStringTrue(text, pattern, 0, patternsIndex);
            }
            else
            {
                result = SearchPatternStringFalse(text, pattern, 0, patternsIndex);
            }

            static int[] SearchPatternStringTrue(string text, string pattern, int indexBegine, List<int> patternsIndex)
            {
                int index = text.IndexOf(pattern, indexBegine, StringComparison.InvariantCultureIgnoreCase);

                if (indexBegine > text.Length - pattern.Length || index == -1)
                {
                    return patternsIndex.ToArray();
                }

                patternsIndex.Add(index + 1);
                indexBegine = index + 1;

                return SearchPatternStringTrue(text, pattern, indexBegine, patternsIndex);
            }

            static int[] SearchPatternStringFalse(string text, string pattern, int indexBegine, List<int> patternsIndex)
            {
                int index = text.IndexOf(pattern, indexBegine, StringComparison.InvariantCultureIgnoreCase);

                if (indexBegine > text.Length - pattern.Length || index == -1)
                {
                    return patternsIndex.ToArray();
                }

                patternsIndex.Add(index + 1);
                indexBegine = index;

                return SearchPatternStringFalse(text, pattern, indexBegine + pattern.Length, patternsIndex);
            }

            return result;
        }
    }
}
