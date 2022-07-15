using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace InsertionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with insertion sort algorithm.
        /// </summary>
        public static void InsertionSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"{array}");
            }

            if (array.Length <= 1)
            {
                return;
            }

            for (int i = 1; i < array.Length; i++)
            {
                int min = i;
                for (int j = i; j >= 0; j--)
                {
                    if (array[i] < array[j])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    int number = array[i];
                    for (int k = i; k > min; k--)
                    {
                        array[k] = array[k - 1];
                    }

                    array[min] = number;
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive insertion sort algorithm.
        /// </summary>
        public static void RecursiveInsertionSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"{array}");
            }

            if (array.Length <= 1)
            {
                return;
            }

            RecursiveInsertionSort(array, 1);
        }

        private static void RecursiveInsertionSort(int[] array, int num)
        {
            if (num >= array.Length)
            {
                return;
            }

            int min = num;
            for (int j = num; j >= 0; j--)
            {
                if (array[num] < array[j])
                {
                    min = j;
                }
            }

            if (min != num)
            {
                int number = array[num];
                for (int k = num; k > min; k--)
                {
                    array[k] = array[k - 1];
                }

                array[min] = number;
            }

            num++;
            RecursiveInsertionSort(array, num);
        }
    }
}
