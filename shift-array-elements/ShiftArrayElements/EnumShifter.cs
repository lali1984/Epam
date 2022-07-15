using System;

namespace ShiftArrayElements
{
    public static class EnumShifter
    {
        public static int[] Shift(int[] source, Direction[] directions)
        {
            if (directions == null)
            {
                throw new ArgumentNullException(nameof(directions));
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                return source;
            }

            if (directions.Length == 0)
            {
                return source;
            }

            for (int i = 0; i < directions.Length; i++)
            {
                int shift;
                switch (directions[i])
                {
                    case Direction.Left:
                        {
                            shift = source[0];
                            for (int j = 0; j < source.Length - 1; j++)
                            {
                                source[j] = source[j + 1];
                            }

                            source[^1] = shift;
                            break;
                        }

                    case Direction.Right:
                        {
                            shift = source[^1];
                            for (int j = source.Length - 2; j >= 0; j--)
                            {
                                source[j + 1] = source[j];
                            }

                            source[0] = shift;
                            break;
                        }

                    default:
                            throw new InvalidOperationException($"Incorrect {directions} enum value.");
                }
            }

            return source;
        }
    }
}
