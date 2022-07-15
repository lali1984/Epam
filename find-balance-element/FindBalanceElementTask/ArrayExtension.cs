using System;

namespace FindBalanceElementTask
{
    /// <summary>
    /// Class for operations with arrays.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds an index of element in an integer array for which the sum of the elements
        /// on the left and the sum of the elements on the right are equal.
        /// </summary>
        /// <param name="array">Source array.</param>
        /// <returns>The index of the balance element, if it exists, and null otherwise.</returns>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static int? FindBalanceElement(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"{array}");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException($"{array}");
            }

            if (array.Length < 3)
            {
                return null;
            }
            
            for (int i = 1, j = i + 1; i < array.Length - 1; i++, j++)
            {
                int left = 0;
                int right = 0;
                foreach (int l in array[0..i])
                {
                    if (l == int.MaxValue)
                    {
                        left += 1;
                    }
                    else if (l == int.MinValue)
                    {
                        left -= 1;
                    }
                    else
                    {
                        left += l;
                    }
                }

                foreach (int r in array[j..^0])
                {
                    if (r == int.MaxValue)
                    {
                        right += 1;
                    }
                    else if (r == int.MinValue)
                    {
                        right -= 1;
                    }
                    else
                    {
                        right += r;
                    }
                }

                if (left == right)
                {
                    return i;
                }
            }

            return null;
        }
    }
}
