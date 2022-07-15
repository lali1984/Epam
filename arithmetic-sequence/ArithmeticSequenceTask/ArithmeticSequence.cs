using System;
using System.Linq;

namespace ArithmeticSequenceTask
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (count < 0)
            {
                throw new ArgumentException($"{nameof(count)}, is less than 0");
            } 

            if (number == int.MinValue && add < 0)
            {
                throw new OverflowException(nameof(number));
            }

            if (number == int.MaxValue && add > 0)
            {
                throw new OverflowException(nameof(number));
            }

            int[] myElements;
            myElements = new int[count];
            for (int i = 0; i < count; i++)
            {                
                myElements[i] = number + (add * i);
            }

            return myElements.Sum();
        }
    }
}
