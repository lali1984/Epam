using System;

namespace ShiftArrayElements
{
    public static class RecursiveShifter
    {
        /// <summary>
        /// Shifts elements in a <see cref="source"/> array using <see cref="iterations"/> array for getting directions and iterations (odd elements - left direction, even elements - right direction).
        /// </summary>
        /// <param name="source">A source array.</param>
        /// <param name="iterations">An array with iterations.</param>
        /// <returns>An array with shifted elements.</returns>
        /// <exception cref="ArgumentNullException">source array is null.</exception>
        /// <exception cref="ArgumentNullException">iterations array is null.</exception>
        public static int[] Shift(int[] source, int[] iterations)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (iterations == null)
            {
                throw new ArgumentNullException(nameof(iterations));
            }

            if (source.Length < 2)
            {
                return source;
            }

            LocalShift(source, iterations, 0);

            static void LocalShift(int[] source, int[] iterations, int shift) 
            {
                if (shift > iterations.Length - 1)
                {
                    return;
                }

                if ((shift & 1) == 0 || shift == 0)
                {
                    ShiftInLeft(source, iterations[shift] % source.Length);
                }
                else if ((shift & 1) == 1)
                {
                    ShiftInRight(source, iterations[shift] % source.Length);
                }

                LocalShift(source, iterations, shift + 1);
            }

            static void ShiftInLeft(int[] source, int iterationsShift)
            {
                if (iterationsShift <= 0)
                {
                    return;
                }

                IndexShifter(source, source.Length - 1);

                static void IndexShifter(int[] source, int index)
                {
                    if (index == 0)
                    {
                        return;
                    }

                    (source[0], source[index]) = (source[index], source[0]);

                    IndexShifter(source, index - 1);
                }

                ShiftInLeft(source, iterationsShift - 1);
            }

            static void ShiftInRight(int[] source, int iterationsShift)
            {
                if (iterationsShift <= 0)
                {
                    return;
                }

                IndexShifter(source, 0);

                static void IndexShifter(int[] source, int index)
                {
                    if (index == source.Length - 1)
                    {
                        return;
                    }

                    (source[^1], source[index]) = (source[index], source[^1]);

                    IndexShifter(source, index + 1);
                }

                ShiftInRight(source, iterationsShift - 1);
            }

            return source;
        }
    }
}
