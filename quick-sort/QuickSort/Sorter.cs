using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace QuickSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with quick sort algorithm.
        /// </summary>
        public static void QuickSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"{array}");
            }

            if (array.Length == 0)
            {
                return;
            }

            SortArray(array, 0, array.Length - 1);

            static void SortArray(int[] array, int leftIndex, int rightIndex)
            {
                int i = leftIndex;
                int j = rightIndex;
                int pivot = array[leftIndex];
                while (i <= j)
                {
                    while (array[i] < pivot)
                    {
                        i++;
                    }

                    while (array[j] > pivot)
                    {
                        j--;
                    }

                    if (i <= j)
                    {
                        (array[j], array[i]) = (array[i], array[j]);
                        i++;
                        j--;
                    }
                }

                if (leftIndex < j)
                {
                    SortArray(array, leftIndex, j);
                }

                if (i < rightIndex)
                {
                    SortArray(array, i, rightIndex);
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive quick sort algorithm.
        /// </summary>
        public static void RecursiveQuickSort(this int[] array)
        {
            NullArray(array);

            Sort(array, 0, array.Length - 1);
        }

        public static void NullArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"{array}");
            }
        }

        public static int[] Sort(int[] array, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return array;
            }

            int pivodIndex = GetPivod(array, startIndex, endIndex);

            Sort(array, startIndex, pivodIndex - 1);
            Sort(array, pivodIndex + 1, endIndex);

            return array;
        }

        public static int GetPivod(int[] array, int startIndex, int endIndex)
        {
            NullArray(array);

            int pivodIndex = startIndex - 1;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (array[i] < array[endIndex])
                {
                    pivodIndex++;
                    Swap(ref array[pivodIndex], ref array[i]);
                }
            }

            pivodIndex++;
            Swap(ref array[pivodIndex], ref array[endIndex]);

            return pivodIndex;
        }

        public static void Swap(ref int left, ref int rigth)
        {
            (rigth, left) = (left, rigth);
        }
    }
}
