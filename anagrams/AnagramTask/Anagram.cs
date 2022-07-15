using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramTask
{
    public class Anagram
    {
        private readonly string word;
        private readonly System.Globalization.CultureInfo cultureInfo = System.Globalization.CultureInfo.CurrentCulture;

        /// <summary>
        /// Initializes a new instance of the <see cref="Anagram"/> class.
        /// </summary>
        /// <param name="sourceWord">Source word.</param>
        /// <exception cref="ArgumentNullException">Thrown when source word is null.</exception>
        /// <exception cref="ArgumentException">Thrown when  source word is empty.</exception>
        public Anagram(string sourceWord)
        {
            if (sourceWord == null)
            {
                throw new ArgumentNullException(nameof(sourceWord));
            }

            if (sourceWord.Length == 0)
            {
                throw new ArgumentException("The word cannot be empty.");
            }

            this.word = sourceWord.ToLower(this.cultureInfo);
        }

        /// <summary>
        /// From the list of possible anagrams selects the correct subset.
        /// </summary>
        /// <param name="candidates">A list of possible anagrams.</param>
        /// <returns>The correct sublist of anagrams.</returns>
        /// <exception cref="ArgumentNullException">Thrown when candidates list is null.</exception>
        public string[] FindAnagrams(string[] candidates)
        {
            if (candidates == null)
            {
                throw new ArgumentNullException(nameof(candidates));
            }

            if (candidates.Length == 0)
            {
                throw new ArgumentNullException(nameof(candidates));
            }

            List<string> result = new List<string>();

            foreach (string candidate in candidates)
            {
                if (candidate.Length != this.word.Length)
                {
                    continue;
                }

                if (candidate.ToLower(this.cultureInfo) == this.word)
                {
                    continue;
                }

                StringBuilder words = new StringBuilder();
                string wordStr = this.word;
                char[] candidateChars = candidate.ToLower(this.cultureInfo).ToCharArray();

                foreach (char c in candidateChars)
                {
                    int i = 0;

                    foreach (char w in wordStr)
                    {
                        if (c == w)
                        {
                            words.Append(c);
                            wordStr = wordStr.Remove(i, 1);
                            break;
                        }

                        i++;
                    }
                }

                if (words.ToString() == candidate.ToLower(this.cultureInfo))
                {
                    result.Add(candidate);
                }
            }

            return result.ToArray();
        }
    }
}
