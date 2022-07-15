using System;
using System.Collections.Generic;

namespace RotateMatrix
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Rotates the image clockwise by 90° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate90DegreesClockwise(this int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            List<int> number = new List<int>();
            int size = (int)Math.Sqrt(matrix.Length);
            int num = 0;
            foreach (int x in matrix)
            {
                number.Add(x);
            }

            for (int i = size - 1; i >= 0; i--)
            {
                for (int j = 0; j < size; j++, num++)
                {
                    matrix[j, i] = number[num];
                }
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 90° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate90DegreesCounterClockwise(this int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            List<int> number = new List<int>();
            int size = (int)Math.Sqrt(matrix.Length);
            int num = 0;
            foreach (int x in matrix)
            {
                number.Add(x);
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j >= 0; j--, num++)
                {
                    matrix[j, i] = number[num];
                }
            }
        }

        /// <summary>
        /// Rotates the image clockwise by 180° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate180DegreesClockwise(this int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            List<int> number = new List<int>();
            int size = (int)Math.Sqrt(matrix.Length);
            int num = 0;
            foreach (int x in matrix)
            {
                number.Add(x);
            }

            for (int i = size - 1; i >= 0; i--)
            {
                for (int j = size - 1; j >= 0; j--, num++)
                {
                    matrix[i, j] = number[num];
                }
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 180° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate180DegreesCounterClockwise(this int[,] matrix)
        {
            Rotate180DegreesClockwise(matrix);        
        }

        /// <summary>
        /// Rotates the image clockwise by 270° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate270DegreesClockwise(this int[,] matrix)
        {
            Rotate90DegreesCounterClockwise(matrix);
        }

        /// <summary>
        /// Rotates the image counterclockwise by 270° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate270DegreesCounterClockwise(this int[,] matrix)
        {
            Rotate90DegreesClockwise(matrix);
        }

        /// <summary>
        /// Rotates the image clockwise by 360° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate360DegreesClockwise(this int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            List<int> number = new List<int>();
            int size = (int)Math.Sqrt(matrix.Length);
            int num = 0;
            foreach (int x in matrix)
            {
                number.Add(x);
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++, num++)
                {
                    matrix[i, j] = number[num];
                }
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 360° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate360DegreesCounterClockwise(this int[,] matrix)
        {
            Rotate360DegreesClockwise(matrix);  
        }
    }
}
