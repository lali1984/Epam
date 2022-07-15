using System;
using System.Collections.Generic;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число \n");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число: {number}");
            List<int> nextBigger = new List<int>();
            do
            {
                nextBigger.Add(number % 10);
                number /= 10;
            }
            while (number != 0);
            int i, j = 1;
           
            for (i = 0; i < nextBigger.Count - 1; i++, j++)
            {
                if (nextBigger[i] > nextBigger[j])
                {
                    int n = nextBigger[i];
                    nextBigger[i] = nextBigger[j];
                    nextBigger[i + 1] = n;
                    break;
                }
            }
            for (i = 0; i < j - 1; i++)
            {
                if (nextBigger[i] < nextBigger[i + 1])
                {
                    (nextBigger[i + 1], nextBigger[i]) = (nextBigger[i], nextBigger[i + 1]);
                }
            }
            Console.WriteLine("Ваш список цифр:");
            foreach (int k in nextBigger)
            {
                Console.WriteLine(k);
            }
           

           
        }
    }
}
