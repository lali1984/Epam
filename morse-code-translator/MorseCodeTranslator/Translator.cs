using System;
using System.Globalization;
using System.Text;

#pragma warning disable S2368

namespace MorseCodeTranslator
{
    public static class Translator
    {
        public static string TranslateToMorse(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException($"{message} is null.");
            }

            StringBuilder morseString = new StringBuilder();
            char[][] codeTable = MorseCodes.CodeTable;

            WriteMorse(codeTable, message, morseString, '.', '-', ' ');

            return morseString.ToString().Trim(' ');
        }

        public static string TranslateToText(string morseMessage)
        {
            if (morseMessage == null)
            {
                throw new ArgumentNullException($"{morseMessage} is null.");
            }

            StringBuilder morseString = new StringBuilder();
            char[][] codeTable = MorseCodes.CodeTable;
            WriteText(codeTable, morseMessage, morseString, '.', '-', ' ');

            return morseString.ToString();
        }

        public static void WriteMorse(char[][] codeTable, string message, StringBuilder morseMessageBuilder, char dot = '.', char dash = '-', char separator = ' ')
        {
            if (codeTable == null || message == null || morseMessageBuilder == null)
            {
                throw new ArgumentNullException($"{codeTable}, {message} is null.");
            }

            foreach (char later in message)
            {
                foreach (char[] morse in codeTable)
                {
                    if (char.ToUpper(later, CultureInfo.InvariantCulture) == morse[0])
                    {
                        morseMessageBuilder.Append(string.Concat(morse[1..]) + ' ');
                        break;
                    }
                }
            }

            if (morseMessageBuilder.Length > 0)
            {
                morseMessageBuilder.Remove(morseMessageBuilder.Length - 1, 1);
                morseMessageBuilder.Replace('.', dot);
                morseMessageBuilder.Replace('-', dash);
                morseMessageBuilder.Replace(' ', separator);
            }
        }

        public static void WriteText(char[][] codeTable, string morseMessage, StringBuilder messageBuilder, char dot = '.', char dash = '-', char separator = ' ')
        {
            if (codeTable == null || morseMessage == null || messageBuilder == null)
            {
                throw new ArgumentNullException($"{codeTable}, {morseMessage} is null.");
            }

            StringBuilder morseMessageReplace = new StringBuilder(morseMessage);
            morseMessageReplace.Replace(separator, ' ');
            morseMessageReplace.Replace(dot, '.');
            morseMessageReplace.Replace(dash, '-');

            string[] morseStrings = morseMessageReplace.ToString().Split(' ');

            foreach (string morseLiterals in morseStrings)
            {
                foreach (char[] morse in codeTable)
                {
                    if (morseLiterals == string.Concat(morse[1..]))
                    {
                        messageBuilder.Append(morse[0]);
                        break;
                    }
                }
            }
        }
    }
}
