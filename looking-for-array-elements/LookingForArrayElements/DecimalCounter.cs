using System;

#pragma warning disable S2368

namespace LookingForArrayElements
{
    public static class DecimalCounter
    {
        public static int GetDecimalsCount(decimal[] arrayToSearch, decimal[][] ranges)
        {
            if (arrayToSearch == null || ranges == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            foreach (decimal[] range in ranges)
            {
                if (range == null)
                {
                    throw new ArgumentNullException(nameof(arrayToSearch));
                }

                if (range.Length > 2)
                {
                    throw new ArgumentException(" length of one of the ranges is less or greater than 2 ");
                }
            }

            if (arrayToSearch.Length == 0 || ranges.Length == 0)
            {
                return 0;
            }

            int number = 0;
            int i = 0;
            do
            {
                int j = 0;
                do
                {
                    if (ranges[j].Length == 0)
                    {
                        break;
                    }

                    if (arrayToSearch[i] >= ranges[j][0] && arrayToSearch[i] <= ranges[j][1])
                    {
                        number++;
                        break;
                    }

                    j++;
                }
                while (j < ranges.Length);

                i++;
            }
            while (i < arrayToSearch.Length);

            return number;
        }

        public static int GetDecimalsCount(decimal[] arrayToSearch, decimal[][] ranges, int startIndex, int count)
        {
            int number = 0;
            if (arrayToSearch == null || ranges == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            foreach (decimal[] range in ranges)
            {
                if (range == null)
                {
                    throw new ArgumentNullException(nameof(arrayToSearch));
                }

                if (range.Length > 2)
                {
                    throw new ArgumentException(" length of one of the ranges is less or greater than 2 ");
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

            if (arrayToSearch.Length == 0 || ranges.Length == 0)
            {
                return 0;
            }

            for (int i = startIndex; i < startIndex + count; i++)
            {
                for (int j = 0; j < ranges.Length; j++)
                {
                    if (ranges[j].Length == 0)
                    {
                        break;
                    }

                    if (arrayToSearch[i] >= ranges[j][0] && arrayToSearch[i] <= ranges[j][1])
                    {
                        number++;
                        break;
                    }
                }
            }

            return number;
        }
    }
}
