using System;

namespace LookingForArrayElements
{
    public static class FloatCounter
    {
        public static int GetFloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd)
        {
            if (arrayToSearch == null || rangeStart == null || rangeEnd == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException(" different rangeEnd and rangeStart ");
            }

            for (int i = 0; i < rangeEnd.Length; i++)
            {
                if (rangeEnd[i] < rangeStart[i])
                {
                    throw new ArgumentException(" range start value is greater than the range end value ");
                }
            }

            if (arrayToSearch.Length == 0 || rangeStart.Length == 0 || rangeEnd.Length == 0)
            {
                return 0;
            }

            int number = 0;
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (arrayToSearch[i] >= rangeStart[j] && arrayToSearch[i] <= rangeEnd[j])
                    {
                        number++;
                    }
                }
            }

            return number;
        }

        public static int GetFloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd, int startIndex, int count)
        {
            if (arrayToSearch == null || rangeStart == null || rangeEnd == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException(" different rangeEnd and rangeStart ");
            }

            for (int k = 0; k < rangeEnd.Length; k++)
            {
                if (rangeEnd[k] < rangeStart[k])
                {
                    throw new ArgumentException(" range start value is greater than the range end value ");
                }
            }

            if (count < 0 || startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if (startIndex + count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayToSearch));
            }

            if (arrayToSearch.Length == 0 || rangeStart.Length == 0 || rangeEnd.Length == 0)
            {
                return 0;
            }

            int number = 0;
            int j = 0;
            do
            {
                int i = startIndex;
                do
                {
                    if (arrayToSearch[i] >= rangeStart[j] && arrayToSearch[i] <= rangeEnd[j])
                    {
                        number++;
                    }

                    i++;
                }
                while (i < (startIndex + count));

                j++;
            }
            while (j < rangeStart.Length);

            return number;
        }
    }
}
