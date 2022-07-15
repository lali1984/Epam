using System;

namespace LookingForArrayElements
{
    public static class IntegersCounter
    {
        public static int GetIntegersCount(int[] arrayToSearch, int[] elementsToSearchFor)
        {
            if (arrayToSearch == null || elementsToSearchFor == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch), $"{nameof(elementsToSearchFor)} is null");
            }

            int number = 0;
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                for (int j = 0; j < elementsToSearchFor.Length; j++)
                {
                    if (arrayToSearch[i] == elementsToSearchFor[j])
                    {
                        number++;
                    }
                }
            }

            return number;
        }

        public static int GetIntegersCount(int[] arrayToSearch, int[] elementsToSearchFor, int startIndex, int count)
        {
            if (arrayToSearch == null || elementsToSearchFor == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch), $"{nameof(elementsToSearchFor)} is null");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (startIndex + count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayToSearch));
            }

            int number = 0;
            for (int i = startIndex; i < startIndex + count; i++)
            {
                for (int j = 0; j < elementsToSearchFor.Length; j++)
                {
                    if (arrayToSearch[i] == elementsToSearchFor[j])
                    {
                        number++;
                    }
                }
            }

            return number;
        }
    }
}
