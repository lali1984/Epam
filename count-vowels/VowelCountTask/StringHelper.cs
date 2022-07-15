using System;

namespace VowelCountTask
{
    public static class StringHelper
    {
        public static int GetCountOfVowel(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentException("source is null or empty");
            }

            int countVowel = 0;
            char[] charsVowel = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            char[] sourse = source.ToCharArray();
            for (int sourceIndex = 0; sourceIndex < sourse.Length; sourceIndex++)
            {
                for (int vowelIndex = 0; vowelIndex < charsVowel.Length; vowelIndex++)
                {
                    if (source[sourceIndex] == charsVowel[vowelIndex])
                    {
                        countVowel++;
                    }
                }
            }

            return countVowel;
        }
    }
}
