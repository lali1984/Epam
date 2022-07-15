using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace BubbleSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with bubble sort algorithm.
        /// </summary>
        public static void BubbleSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"{array}");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        (array[j], array[j - 1]) = (array[j - 1], array[j]);
                    }
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive bubble sort algorithm.
        /// </summary>
        public static void RecursiveBubbleSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"{array}");
            }

            RecursiveBubbleSort(array, 0);

            static void RecursiveBubbleSort(int[] array, int i)
            {
                if (i >= array.Length)
                {
                    return;
                }

                BubbleSort(array, array.Length - 1, i);
                RecursiveBubbleSort(array, i + 1);
            }

            static void BubbleSort(int[] arraySort, int number, int begin)
            {
                if (number == begin)
                {
                    return;
                }

                if (arraySort[number - 1] > arraySort[number])
                {
                    (arraySort[number], arraySort[number - 1]) = (arraySort[number - 1], arraySort[number]);
                }

                BubbleSort(arraySort, number - 1, begin);
            }
        }
    }
}
