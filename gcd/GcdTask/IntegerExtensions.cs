using System;

namespace GcdTask
{
    public static class IntegerExtensions
    {
        public static int FindGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("all numbers are 0 at the same time.");
            }

            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
                throw new ArgumentOutOfRangeException(nameof(b));
            } 

            a = Math.Abs(a);
            b = Math.Abs(b);

            do
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            while (a != 0 && b != 0);

            return Math.Max(a, b);
        }
    }
}
