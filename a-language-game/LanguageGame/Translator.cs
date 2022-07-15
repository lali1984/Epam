using System;
using System.Globalization;

namespace LanguageGame
{
    public static class Translator
    {
        /// <summary>
        /// Translates from English to Pig Latin. Pig Latin obeys a few simple following rules:
        /// - if word starts with vowel sounds, the vowel is left alone, and most commonly 'yay' is added to the end;
        /// - if word starts with consonant sounds or consonant clusters, all letters before the initial vowel are
        ///   placed at the end of the word sequence. Then, "ay" is added.
        /// Note: If a word begins with a capital letter, then its translation also begins with a capital letter,
        /// if it starts with a lowercase letter, then its translation will also begin with a lowercase letter.
        /// </summary>
        /// <param name="phrase">Source phrase.</param>
        /// <returns>Phrase in Pig Latin.</returns>
        /// <exception cref="ArgumentException">Thrown if phrase is null or empty.</exception>
        /// <example>
        /// "apple" -> "appleyay"
        /// "Eat" -> "Eatyay"
        /// "explain" -> "explainyay"
        /// "Smile" -> "Ilesmay"
        /// "Glove" -> "Oveglay".
        /// </example>
        public static string TranslateToPigLatin(string phrase)
        {
            if (phrase == null || phrase.Length == 0 || string.IsNullOrWhiteSpace(phrase))
            {
                throw new ArgumentException($"{phrase} is null or empty");
            }

            string[] wordsArray = phrase.Split(new char[] { ' ' }, StringSplitOptions.None);

            string vowel = "aeoiu";
            int j = 0;

            foreach (string word in wordsArray)
            {
                int i = 0;
                string[] subWordsArray = word.Split(new char[] { '-' }, StringSplitOptions.None);
                
                foreach (string subWord in subWordsArray)
                {
                    if (subWord.Length == 0)
                    {
                        i++;
                        continue;
                    }

                    int vowelIndex = FindeVowelIndex(subWord, vowel);
                    
                    if (vowelIndex == 0)
                    {
                        subWordsArray[i] = VowelRules(subWord);
                    }
                    else if (vowelIndex > 0)
                    {
                        subWordsArray[i] = ConsonantRules(subWord, vowelIndex);
                    }
                    else if (vowelIndex == -1)
                    {
                        subWordsArray[i] = ConsonantRules(subWord, 0);
                    }

                    i++;
                }

                wordsArray[j] = string.Join('-', subWordsArray);
                j++;
            }

            static int FindeVowelIndex(string word, string vowel)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    foreach (char vol in vowel)
                    {
                        if (char.ToLower(word[i], CultureInfo.CurrentCulture) == vol)
                        {
                            return i;
                        }
                    }
                }

                return -1;
            }

            static string VowelRules(string word)
            {
                string endVowel = "yay";

                if (!char.IsLetter(word[^1]))
                {
                    return string.Concat(word[..^1], endVowel, word[^1]);
                }

                return string.Concat(word, endVowel); 
            }

            static string ConsonantRules(string word, int vowelIndex)
            {
                string endConsonant = "ay";
                string word1;

                if (!char.IsLetter(word[^1]))
                {
                    word1 = string.Concat(word[vowelIndex..^1], word[..vowelIndex], endConsonant, word[^1]);
                }
                else
                {
                    word1 = string.Concat(word[vowelIndex..], word[..vowelIndex], endConsonant);
                }

                if (char.IsUpper(word[0]))
                {
                    word1 = string.Concat(char.ToUpperInvariant(word1[0]), word1[1..].ToLower(CultureInfo.CurrentCulture));
                }

                return word1;
            }

            return string.Join(' ', wordsArray);
        }
    }
}
