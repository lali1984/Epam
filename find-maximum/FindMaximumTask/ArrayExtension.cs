using System;

namespace FindMaximumTask
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds the element of the array with the maximum value.
        /// </summary>
        /// <param name="array"> Source array. </param>
        /// <returns>The element of the array with the maximum value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int FindMaximum(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"{array}");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException($"{array}");
            }

            return MaxCoreent(array, 0, array.Length);
        }

        private static int MaxCoreent(int[] array, int start, int length)
        {
            if (start == length - 1)
            {
                return array[start];
            }

            int mid = (start + length) / 2;
            int left = MaxCoreent(array, start, mid);
            int right = MaxCoreent(array, mid, length);

            return (left > right) ? left : right;
        }
    }
}
