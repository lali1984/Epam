using System;

namespace ShiftArrayElements
{
    public static class RecursiveEnumShifter
    {
        /// <summary>
        /// Shifts elements in a <see cref="source"/> array using directions from <see cref="directions"/> array, one element shift per each direction array element.
        /// </summary>
        /// <param name="source">A source array.</param>
        /// <param name="directions">An array with directions.</param>
        /// <returns>An array with shifted elements.</returns>
        /// <exception cref="ArgumentNullException">source array is null.</exception>
        /// <exception cref="ArgumentNullException">directions array is null.</exception>
        /// <exception cref="InvalidOperationException">direction array contains an element that is not <see cref="Direction.Left"/> or <see cref="Direction.Right"/>.</exception>
        public static int[] Shift(int[] source, Direction[] directions)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (directions == null)
            {
                throw new ArgumentNullException(nameof(directions));
            }

            if (source.Length == 0)
            {
                return source;
            }

            if (source.Length < 2)
            {
                return source;
            }

            LocalShift(source, directions, 0);

            static void LocalShift(int[] source, Direction[] directions, int shift)
            {
                if (shift > directions.Length - 1)
                {
                    return;
                }

                if (directions[shift] != Direction.Left && directions[shift] != Direction.Right)
                {
                    throw new InvalidOperationException("directions array contains an element that is not Direction.");
                }

                if (directions[shift] == Direction.Left)
                {
                    ShiftInLeft(source);
                }
                else if (directions[shift] == Direction.Right)
                {
                    ShiftInRight(source);
                }

                LocalShift(source, directions, shift + 1);
            }

            static void ShiftInLeft(int[] source)
            {
                int number = source[0];
                Array.Copy(source, 1, source, 0, source.Length - 1);
                source[^1] = number;
            }

            static void ShiftInRight(int[] source)
            {
                int number = source[^1];
                Array.Copy(source, 0, source, 1, source.Length - 1);
                source[0] = number;
            }

            return source;
        }
    }
}
