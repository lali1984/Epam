using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace SelectionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with selection sort algorithm.
        /// </summary>
        public static void SelectionSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"{array}");
            }

            if (array.Length <= 1)
            {
                return;
            }

            int min, num;
            for (int i = 0; i < array.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    num = array[i];
                    array[i] = array[min];
                    array[min] = num;
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive selection sort algorithm.
        /// </summary>
        public static void RecursiveSelectionSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"{array}");
            }

            if (array.Length <= 1)
            {
                return;
            }

            RecursiveSelectionSort(array, 0);

            static void RecursiveSelectionSort(int[] array, int start)
            {
                int min = start;
                int num;
                if (start > array.Length - 1)
                {
                    return;
                }

                for (int j = start + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                if (min != start)
                {
                    num = array[start];
                    array[start] = array[min];
                    array[min] = num;
                }

                start++;
                RecursiveSelectionSort(array, start);
            }
        }
    }
}
