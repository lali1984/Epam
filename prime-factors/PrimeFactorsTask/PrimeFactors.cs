using System;
using System.Collections.Generic;

namespace PrimeFactorsTask
{
    public static class PrimeFactors
    {
        public static int[] GetFactors(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException($"{nameof(number)}, less or equal 0.");
            }

            List<int> factorsNumber = new List<int>();
            
            for (int i = 2; i <= number; ++i)
            {
                if (number % i == 0)
                {
                    factorsNumber.Add(i);
                    number /= i;
                    i = 1;
                }
            }

            int[] factors = factorsNumber.ToArray();
            return factors;
        }
    }
}
