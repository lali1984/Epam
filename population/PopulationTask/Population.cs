using System;

namespace PopulationTask
{
    public static class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException($"{nameof(initialPopulation)} is less or equals 0");
            }

            if (visitors < 0)
            {
                throw new ArgumentException($"{nameof(visitors)} is less 0");
            }

            if (currentPopulation <= 0 || currentPopulation < initialPopulation)
            {
                throw new ArgumentException($"{nameof(currentPopulation)} is less or equls 0");
            }

            if (percent <= 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent));
            }

            int year = 0;
            int current = initialPopulation;

            do
            {
                current += (int)(current / 100 * percent) + visitors;
                year++;
            }
            while (currentPopulation >= current);
            return year;
        }
    }
}
