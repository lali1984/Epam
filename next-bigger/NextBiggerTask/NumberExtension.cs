using System;
using System.Collections.Generic;
using System.Text;

namespace NextBiggerTask
{
    public static class NumberExtension
    {
        public static int? NextBiggerThan(int number)
        {
            int num = number;
            if (num < 0)
            {
                throw new ArgumentException($"{nameof(num)} is less than 0.");
            }

            if (num == int.MaxValue)
            {
                return null;
            }

            List<int> nextBigger = new List<int>();             
            do 
            {
                nextBigger.Add(num % 10);
                num /= 10;
            }
            while (num != 0);
            int i, j = 1;

            for (i = 0; i < nextBigger.Count - 1; i++, j++) 
            {
                if (nextBigger[i] > nextBigger[j])
                {
                    (nextBigger[j], nextBigger[i]) = (nextBigger[i], nextBigger[j]);
                    for (i = 0; i < j; i++)
                    {
                        for (int k = i + 1; k < j; k++)
                        {
                            if (nextBigger[i] < nextBigger[k])
                            {
                                (nextBigger[i], nextBigger[k]) = (nextBigger[k], nextBigger[i]);
                            }
                        }
                    }
                }
            }

            StringBuilder bld = new StringBuilder();
            for (i = nextBigger.Count - 1; i >= 0; i--)
            {
                bld.Append(nextBigger[i]);
            }

#pragma warning disable CA1305 // Укажите IFormatProvider
            int int_num = Convert.ToInt32(bld.ToString());
#pragma warning restore CA1305 // Укажите IFormatProvider

            return (number == int_num) switch
            {
                true => null,
                _ => int_num,
            };
        }
    }
}
