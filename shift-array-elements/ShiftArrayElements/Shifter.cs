using System;

namespace ShiftArrayElements
{
    public static class Shifter
    {
        public static int[] Shift(int[] source, int[] iterations)
        {
            if (iterations == null)
            {
                throw new ArgumentNullException(nameof(iterations));
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0 || iterations.Length == 0)
            {
                return source;
            }

            for (int i = 0; i < iterations.Length; i++)
            {
                if (iterations[i] == 0)
                {
                    continue;
                }

                if (i == 0 || i % 2 == 0)
                {
                    for (int j = 0; j < iterations[i]; j++)
                    {
                        int shift = source[0];
                        Array.Copy(source, 1, source, 0, source.Length - 1);
                        source[^1] = shift;
                    }

                    continue;
                }
                
                if (i % 2 != 0)
                {
                    for (int j = 0; j < iterations[i]; j++)
                    {
                        int shift = source[^1];
                        Array.Copy(source, 0, source, 1, source.Length - 1);
                        source[0] = shift;
                    }
                }
            }

            return source;
        }
    }
}
