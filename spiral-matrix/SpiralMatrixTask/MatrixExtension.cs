using System;

#pragma warning disable CA1814
#pragma warning disable S2368

namespace SpiralMatrixTask
{
    /// <summary>
    /// Matrix manipulation.
    /// </summary>
    public static class MatrixExtension
    {
        /// <summary>
        /// Fills the matrix with natural numbers, starting from 1 in the top-left corner, increasing in an inward, clockwise spiral order.
        /// </summary>
        /// <param name="size">Matrix size.</param>
        /// <returns>Filled matrix.</returns>
        /// <exception cref="ArgumentException">Thrown when matrix size less or equal zero.</exception>
        /// <example> size = 3
        ///     1 2 3
        ///     8 9 4
        ///     7 6 5.
        /// </example>
        /// <example> size = 4
        ///     1  2  3  4
        ///     12 13 14 5
        ///     11 16 15 6
        ///     10 9  8  7.
        /// </example>
        public static int[,] GetMatrix(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Size of matrix is 0 or less."); 
            }

            int[,] matrix = new int[size, size];
            int number = 1;
            int start = 0;
            int j, i;
           
            while (number <= matrix.Length)
            {
                for (i = start, j = start; i < size - start; ++i)
                {
                    matrix[j, i] = number;
                    number++;
                }

                for (j = start + 1, i = size - start - 1; j < size - start; ++j)
                {
                    matrix[j, i] = number;
                    number++;
                }

                for (i = size - start - 2, j = size - start - 1; i >= start; --i)
                {
                    matrix[j, i] = number;
                    number++;
                }

                for (j = size - start - 2, i = start; j > start; --j)
                {
                    matrix[j, i] = number;
                    number++;
                }

                start++;
            }

            return matrix;
        }
    }
}
