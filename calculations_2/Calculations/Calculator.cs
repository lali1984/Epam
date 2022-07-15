using System;

namespace Calculations
{
    public static class Calculator
    {
        public static double GetSumOne(int n)
        {
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += 1 / i;
            }

            return sum;
        }
        
        public static double GetSumTwo(int n)
        {
            double sum = 0;
            double num = -1;
            for (double i = 1; i <= n; i++)
            {
                num *= -1;
                sum += num / (i * (i + 1)); 
            }

            return sum;
        }
        
        public static double GetSumThree(int n)
        {
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += 1 / Math.Pow(i, 5);
            }

            return sum;
        }
        
        public static double GetSumFour(int n)
        {
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += 1 / Math.Pow((2 * i) + 1, 2); 
            }

            return sum;
        }

        public static double GetProductOne(int n)
        {
            double sum = 1;
            for (double i = 1; i <= n; i++)
            {
                sum *= 1 + (1 / (i * i));
            }

            return sum;
        }
        
        public static double GetSumFive(int n)
        {
            double sum = 0;
            double num = 1;
            for (double i = 1; i <= n; i++)
            {
                num *= -1;
                sum += num / ((2 * i) + 1);
            }

            return sum;
        }

        public static double GetSumSix(int n)
        {
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                double factorial_n = 1;
                double num = 0;

                for (double j = 1; j <= i; j++)
                {
                    factorial_n *= j;
                    num += 1 / j;
                }

                sum += factorial_n / num;
            }

            return sum;
        }

        public static double GetSumSeven(int n)
        {
            double sum = Math.Sqrt(2);
            for (double i = 1; i < n; i++)
            {
                sum += 2;
                sum = Math.Sqrt(sum);
            }

            return sum;
        }
        
        public static double GetSumEight(int n)
        {
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                double sin = 0;
                for (double j = 1; j <= i; j++)
                {
                    double rad = Math.PI * j / 180;
                    sin += Math.Sin(rad);
                }

                sum += 1 / sin;
            }

            return sum;
        }
    }
}
