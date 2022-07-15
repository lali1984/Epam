using System;
using System.Diagnostics;
using System.Threading;

namespace Gcd
{
    public static class IntegerExtensions
    {
        public static int GetGcdByEuclidean(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("all numbers are 0 at the same time.");
            }
            else if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), "One or two numbers are int.MinValue.");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            int gcd;
            if (a == b)
            {
                gcd = b;
            }
            else if (b == 0)
            {
                gcd = a;
            }
            else if (a == 0)
            {
                gcd = b;
            }
            else
            {
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

                gcd = Math.Max(a, b);
            }

            return gcd;
        }

        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("all numbers are 0 at the same time.");
            }
            else if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), $"{nameof(c)}Numbers can not be int.MinValue.");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);
            int gcd_1;
            if (a == b)
            {
                gcd_1 = b;
            }
            else if (b == 0)
            {
                gcd_1 = a;
            }
            else if (a == 0)
            {
                gcd_1 = b;
            }
            else
            {
                while (a != 0 && b != 0) 
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

                gcd_1 = Math.Max(a, b);
            }

            int gcd;
            if (c == gcd_1)
            {
                return c;
            }
            else if (c == 0)
            {
                return gcd_1;
            }
            else
            {
                do
                {
                    if (c > gcd_1)
                    {
                        c -= gcd_1;
                    }
                    else
                    {
                        gcd_1 -= c;
                    }
                }
                while (c != 0 && gcd_1 != 0);
            }

            gcd = Math.Max(c, gcd_1);
            return gcd;
        }

        public static int GetGcdByEuclidean(int a, int b, params int[] other)
        {
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), "One or two numbers are int.MinValue.");
            }

            int num = 0;
            for (int i = 0; i < other.Length; i++)
            {
                num += Math.Abs(other[i]);
                if (other[i] == int.MinValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(other));
                }
            }

            if (a == 0 && b == 0 && num == 0)
            {
                throw new ArgumentException("all numbers are 0 at the same time.");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            
            int d = Math.Max(a, b);
            for (int i = 0; i < other.Length; i++)
            {
                int c = Math.Abs(other[i]);
                while (c != 0 && d != 0) 
                {
                    if (c > d)
                    {
                        c %= d;
                    }
                    else
                    {
                        d %= c;
                    }
                }

                d = Math.Max(c, d);
            }

            return d; 
        }

        public static int GetGcdByStein(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("all numbers are 0 at the same time.");
            }

            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), "One or two numbers are int.MinValue.");
            }

            int tmp;
            int gcd = 1;
            int c = 0;
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0)
            {
                c = b;
            }
            else if (b == 0)
            {
                c = a;
            }

            while (a != 0 && b != 0)
            {
                if (a == b)
                {
                    c = a;
                }

                if (a == 1 || b == 1)
                {
                    c = 1;
                }

                if ((a & 1) == 0 && (b & 1) == 0) 
                {
                    gcd <<= 1; 
                    a >>= 1; 
                    b >>= 1; 
                    continue;
                }

                if ((a & 1) == 0 && (b & 1) == 1) 
                {
                    a >>= 1;
                    continue;
                }

                if ((a & 1) == 1 && (b & 1) == 0) 
                {
                    b >>= 1;
                    continue;
                }

                if ((a & 1) == 1 && (b & 1) == 1)
                {
                    if (a > b)
                    {
                        a = (a - b) >> 1;
                    }
                    else
                    {
                        tmp = a;
                        a = (b - a) >> 1;
                        b = tmp;
                    }
                }
            }

            c *= gcd;
            return c;
        }

        public static int GetGcdByStein(int a, int b, int c)
        {
            static int GetGcdForTwo(int c, int d)
            {
                if (c == 0)
                {
                    return d;
                }
                else if (d == 0)
                {
                    return c;
                }
                else if (c == d)
                {
                    return c;
                }
                else if (c == 1 || d == 1)
                {
                    return 1;
                }
                else if ((c & 1) == 0)
                {
                    if ((d & 1) == 0)
                    {
                        return GetGcdByStein(c >> 1, d >> 1) << 1;
                    }
                    else
                    {
                        return GetGcdByStein(c >> 1, d);
                    }
                }
                else
                {
                    if ((d & 1) == 0)
                    {
                        return GetGcdByStein(c, d >> 1);
                    }
                    else
                    {
                        return GetGcdByStein(d, c > d ? (c - d) >> 1 : (d - c) >> 1);
                    }
                }
            }

            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("all numbers are 0 at the same time.");
            }

            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), $"{nameof(c)}Numbers can not be int.MinValue.");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);
            int gcd = GetGcdForTwo(GetGcdForTwo(a, b), c);
            return gcd;
        }

        public static int GetGcdByStein(int a, int b, params int[] other)
        {
            static int GetGcdForTwo(int c, int d)
            {
                if (c == 0)
                {
                    return d;
                }
                else if (d == 0)
                {
                    return c;
                }
                else if (c == d)
                {
                    return c;
                }
                else if (c == 1 || d == 1)
                {
                    return 1;
                }
                else if ((c & 1) == 0)
                {
                    if ((d & 1) == 0)
                    {
                        return GetGcdByStein(c >> 1, d >> 1) << 1;
                    }
                    else
                    {
                        return GetGcdByStein(c >> 1, d);
                    }
                }
                else
                {
                    if ((d & 1) == 0)
                    {
                        return GetGcdByStein(c, d >> 1);
                    }
                    else
                    {
                        return GetGcdByStein(d, c > d ? (c - d) >> 1 : (d - c) >> 1);
                    }
                }
            }

            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), "One or two numbers are int.MinValue.");
            }

            int num = 0;
            int gcd = 0;
            for (int i = 0; i < other.Length; i++)
            {
                num += Math.Abs(other[i]);
                if (other[i] == int.MinValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(other));
                }
            }

            if (a == 0 && b == 0 && num == 0)
            {
                throw new ArgumentException("all numbers are 0 at the same time.");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            for (int i = 0; i < other.Length - 1; i++)
            {
                gcd = GetGcdForTwo(GetGcdForTwo(a, b), GetGcdForTwo(Math.Abs(other[i]), Math.Abs(other[i + 1])));
            }

            return gcd;
        }

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b)
        {
            Stopwatch elapsed = new Stopwatch();
            elapsed.Start();
            
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("all numbers are 0 at the same time.");
            }
            else if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), "One or two numbers are int.MinValue.");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            int gcd;
            if (a == b)
            {
                gcd = b;
            }
            else if (b == 0)
            {
                gcd = a;
            }
            else if (a == 0)
            {
                gcd = b;
            }
            else
            {
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

                gcd = Math.Max(a, b);
            }

            elapsed.Stop();
            elapsedTicks = elapsed.ElapsedTicks;
            return gcd;
        }

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, int c)
        {
            Stopwatch elapsed = new Stopwatch();
            elapsed.Start();
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("all numbers are 0 at the same time.");
            }
            else if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), $"{nameof(c)}Numbers can not be int.MinValue.");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);
            int gcd_1;
            if (a == b)
            {
                gcd_1 = b;
            }
            else if (b == 0)
            {
                gcd_1 = a;
            }
            else if (a == 0)
            {
                gcd_1 = b;
            }
            else
            {
                while (a != 0 && b != 0)
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

                gcd_1 = Math.Max(a, b);
            }

            int gcd;
            if (c == gcd_1)
            {
                elapsedTicks = elapsed.ElapsedTicks;
                return c;
            }
            else if (c == 0)
            {
                elapsedTicks = elapsed.ElapsedTicks;
                return gcd_1;
            }
            else
            {
                do
                {
                    if (c > gcd_1)
                    {
                        c -= gcd_1;
                    }
                    else
                    {
                        gcd_1 -= c;
                    }
                }
                while (c != 0 && gcd_1 != 0);
            }

            gcd = Math.Max(c, gcd_1);
            elapsed.Stop();
            elapsedTicks = elapsed.ElapsedTicks;
            return gcd;
        }

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, params int[] other)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), "One or two numbers are int.MinValue.");
            }

            int num = 0;
            for (int i = 0; i < other.Length; i++)
            {
                num += Math.Abs(other[i]);
                if (other[i] == int.MinValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(other));
                }
            }

            if (a == 0 && b == 0 && num == 0)
            {
                throw new ArgumentException("all numbers are 0 at the same time.");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            int d = Math.Max(a, b);
            for (int i = 0; i < other.Length; i++)
            {
                int c = Math.Abs(other[i]);
                while (c != 0 && d != 0)
                {
                    if (c > d)
                    {
                        c %= d;
                    }
                    else
                    {
                        d %= c;
                    }
                }

                d = Math.Max(c, d);
            }

            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return d;
        }

        public static int GetGcdByStein(out long elapsedTicks, int a, int b)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("all numbers are 0 at the same time.");
            }

            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), "One or two numbers are int.MinValue.");
            }

            int tmp;
            int gcd = 1;
            int c = 0;
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0)
            {
                c = b;
            }
            else if (b == 0)
            {
                c = a;
            }

            while (a != 0 && b != 0)
            {
                if (a == b)
                {
                    c = a;
                }

                if (a == 1 || b == 1)
                {
                    c = 1;
                }

                if ((a & 1) == 0 && (b & 1) == 0)
                {
                    gcd <<= 1;
                    a >>= 1;
                    b >>= 1;
                    continue;
                }

                if ((a & 1) == 0 && (b & 1) == 1)
                {
                    a >>= 1;
                    continue;
                }

                if ((a & 1) == 1 && (b & 1) == 0)
                {
                    b >>= 1;
                    continue;
                }

                if ((a & 1) == 1 && (b & 1) == 1)
                {
                    if (a > b)
                    {
                        a = (a - b) >> 1;
                    }
                    else
                    {
                        tmp = a;
                        a = (b - a) >> 1;
                        b = tmp;
                    }
                }
            }

            c *= gcd;
            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return c;
        }

        public static int GetGcdByStein(out long elapsedTicks, int a, int b, int c)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            static int GetGcdForTwo(int c, int d)
            {
                if (c == 0)
                {
                    return d;
                }
                else if (d == 0)
                {
                    return c;
                }
                else if (c == d)
                {
                    return c;
                }
                else if (c == 1 || d == 1)
                {
                    return 1;
                }
                else if ((c & 1) == 0)
                {
                    if ((d & 1) == 0)
                    {
                        return GetGcdByStein(c >> 1, d >> 1) << 1;
                    }
                    else
                    {
                        return GetGcdByStein(c >> 1, d);
                    }
                }
                else
                {
                    if ((d & 1) == 0)
                    {
                        return GetGcdByStein(c, d >> 1);
                    }
                    else
                    {
                        return GetGcdByStein(d, c > d ? (c - d) >> 1 : (d - c) >> 1);
                    }
                }
            }

            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("all numbers are 0 at the same time.");
            }

            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), $"{nameof(c)}Numbers can not be int.MinValue.");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);
            int gcd = GetGcdForTwo(GetGcdForTwo(a, b), c);
            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return gcd;
        }

        public static int GetGcdByStein(out long elapsedTicks, int a, int b, params int[] other)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            static int GetGcdForTwo(int c, int d)
            {
                if (c == 0)
                {
                    return d;
                }
                else if (d == 0)
                {
                    return c;
                }
                else if (c == d)
                {
                    return c;
                }
                else if (c == 1 || d == 1)
                {
                    return 1;
                }
                else if ((c & 1) == 0)
                {
                    if ((d & 1) == 0)
                    {
                        return GetGcdByStein(c >> 1, d >> 1) << 1;
                    }
                    else
                    {
                        return GetGcdByStein(c >> 1, d);
                    }
                }
                else
                {
                    if ((d & 1) == 0)
                    {
                        return GetGcdByStein(c, d >> 1);
                    }
                    else
                    {
                        return GetGcdByStein(d, c > d ? (c - d) >> 1 : (d - c) >> 1);
                    }
                }
            }

            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), "One or two numbers are int.MinValue.");
            }

            int num = 0;
            int gcd = 0;
            for (int i = 0; i < other.Length; i++)
            {
                num += Math.Abs(other[i]);
                if (other[i] == int.MinValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(other));
                }
            }

            if (a == 0 && b == 0 && num == 0)
            {
                throw new ArgumentException("all numbers are 0 at the same time.");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            for (int i = 0; i < other.Length - 1; i++)
            {
                gcd = GetGcdForTwo(GetGcdForTwo(a, b), GetGcdForTwo(Math.Abs(other[i]), Math.Abs(other[i + 1])));
            }

            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return gcd;
        }
    }
}
