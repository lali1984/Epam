using System;

namespace WorkingWithArrays
{
    public static class UsingRanges
    {
        public static int[] GetArrayWithAllElements(int[] array)
        {
            int[] new_array = new int[array.Length];
            int i = 0;
            foreach (int elements in new_array)
            {
                new_array[i] = array[i];
                i++;
            }

            return new_array;
        }

        public static int[] GetArrayWithoutFirstElement(int[] array)
        {
            int[] new_array = new int[array.Length - 1];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[i + 1];
            }

            return new_array;
        }

        public static int[] GetArrayWithoutTwoFirstElements(int[] array)
        {
            int[] new_array = new int[array.Length - 2];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[i + 2];
            }

            return new_array;
        }

        public static int[] GetArrayWithoutThreeFirstElements(int[] array)
        {
            int[] new_array = new int[array.Length - 3];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[i + 3];
            }

            return new_array;
        }

        public static int[] GetArrayWithoutLastElement(int[] array)
        {
            int[] new_array = new int[array.Length - 1];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[i];
            }

            return new_array;
        }

        public static int[] GetArrayWithoutTwoLastElements(int[] array)
        {
            int[] new_array = new int[array.Length - 2];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[i];
            }

            return new_array;
        }

        public static int[] GetArrayWithoutThreeLastElements(int[] array)
        {
            int[] new_array = new int[array.Length - 3];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[i];
            }

            return new_array;
        }

        public static bool[] GetArrayWithoutFirstAndLastElements(bool[] array)
        {
            bool[] new_array = new bool[array.Length - 2];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[i + 1];
            }

            return new_array;
        }

        public static bool[] GetArrayWithoutTwoFirstAndTwoLastElements(bool[] array)
        {
            bool[] new_array = new bool[array.Length - 4];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[i + 2];
            }

            return new_array;
        }

        public static bool[] GetArrayWithoutThreeFirstAndThreeLastElements(bool[] array)
        {
            bool[] new_array = new bool[array.Length - 6];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[i + 3];
            }

            return new_array;
        }
    }
}
