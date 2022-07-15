using System;

#pragma warning disable S2368

namespace JaggedArrays
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Orders the rows in a jagged-array by ascending of the sum of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByAscendingBySum(this int[][] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException($"{source}");
            }

            int[] arraySort = ArraySum(source);
            SortArray(arraySort, source, 0, arraySort.Length - 1);
        }

        public static void ArrayNull(int[] array, int[][] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException($"{source}");
            }

            if (array == null)
            {
                throw new ArgumentNullException($"{array}");
            }
        }

        public static void SortArray(int[] array, int[][] source, int leftIndex, int rightIndex)
        {
            ArrayNull(array, source);
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
                    (source[j], source[i]) = (source[i], source[j]);
                    (array[j], array[i]) = (array[i], array[j]);
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
            {
                SortArray(array, source, leftIndex, j);
            }

            if (i < rightIndex)
            {
                SortArray(array, source, i, rightIndex);
            }
        }

        public static int[] ArraySum(int[][] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException($"{source}");
            }

            int i = 0;
            int[] sumArray = new int[source.Length];
            foreach (int[] item in source)
            {
                int sum = 0;
                if (item == null)
                {
                    i++;
                    continue;
                }

                foreach (int item2 in item)
                {
                    sum += item2;
                }

                sumArray[i] = sum;
                i++;
            }

            return sumArray;
        }

        /// <summary>
        /// Orders the rows in a jagged-array by descending of the sum of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByDescendingBySum(this int[][] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException($"{source}");
            }

            int[] arraySort = ArraySum(source);
            SortArray(arraySort, source, 0, arraySort.Length - 1);

            static void SortArray(int[] array, int[][] source, int leftIndex, int rightIndex)
            {
                ArrayNull(array, source);
                int i = leftIndex;
                int j = rightIndex;
                int pivot = array[leftIndex];
                while (i <= j)
                {
                    while (array[i] > pivot)
                    {
                        i++;
                    }

                    while (array[j] < pivot)
                    {
                        j--;
                    }

                    if (i <= j)
                    {
                        (source[j], source[i]) = (source[i], source[j]);
                        (array[j], array[i]) = (array[i], array[j]);
                        i++;
                        j--;
                    }
                }

                if (leftIndex < j)
                {
                    SortArray(array, source, leftIndex, j);
                }

                if (i < rightIndex)
                {
                    SortArray(array, source, i, rightIndex);
                }
            }
        }
        
        /// <summary>
        /// Orders the rows in a jagged-array by ascending of the max of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByAscendingByMax(this int[][] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException($"{source}");
            }

            SortArray(source, 0, source.Length - 1);
            static int FindeMax(int[] array)
            {
                if (array == null)
                {
                    return -1;
                }

                int maximum = int.MinValue;
                foreach (int item in array)
                {
                    if (item > maximum)
                    {
                        maximum = item;
                    }
                }

                return maximum;
            }

            static void SortArray(int[][] source, int leftIndex, int rightIndex)
            {
                if (source == null)
                {
                    throw new ArgumentNullException($"{source}");
                }

                int i = leftIndex;
                int j = rightIndex;
                int pivot = FindeMax(source[leftIndex]);
                while (i <= j)
                {
                    while (FindeMax(source[i]) < pivot)
                    {
                        i++;
                    }

                    while (FindeMax(source[j]) > pivot)
                    {
                        j--;
                    }

                    if (i <= j)
                    {
                        (source[j], source[i]) = (source[i], source[j]);
                        i++;
                        j--;
                    }
                }

                if (leftIndex < j)
                {
                    SortArray(source, leftIndex, j);
                }

                if (i < rightIndex)
                {
                    SortArray(source, i, rightIndex);
                }
            }
        }
        
        /// <summary>
        /// Orders the rows in a jagged-array by descending of the max of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByDescendingByMax(this int[][] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException($"{source}");
            }

            int[] maxArray = FindeMax(source);
            SortArray(maxArray, source, 0, maxArray.Length - 1);
            static void SortArray(int[] array, int[][] source, int leftIndex, int rightIndex)
            {
                ArrayNull(array, source);
                int i = leftIndex;
                int j = rightIndex;
                int pivot = array[leftIndex];
                while (i <= j)
                {
                    while (array[i] > pivot)
                    {
                        i++;
                    }

                    while (array[j] < pivot)
                    {
                        j--;
                    }

                    if (i <= j)
                    {
                        (source[j], source[i]) = (source[i], source[j]);
                        (array[j], array[i]) = (array[i], array[j]);
                        i++;
                        j--;
                    }
                }

                if (leftIndex < j)
                {
                    SortArray(array, source, leftIndex, j);
                }

                if (i < rightIndex)
                {
                    SortArray(array, source, i, rightIndex);
                }
            }
        }

        public static int[] FindeMax(int[][] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException($"{source}");
            }

            int i = 0;
            int[] maxArray = new int[source.Length];
            foreach (int[] item in source)
            {
                int max = int.MinValue;
                if (item == null)
                {
                    maxArray[i] = -1;
                    i++;
                    continue;
                }

                foreach (int item2 in item)
                {
                    if (item2 > max)
                    {
                        max = item2;
                    }
                }

                maxArray[i] = max;
                i++;
            }

            return maxArray;
        }
    }
}
