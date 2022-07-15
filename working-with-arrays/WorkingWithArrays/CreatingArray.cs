using System;
using System.Linq;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        public static int[] CreateEmptyArrayOfIntegers()
        {
            return Array.Empty<int>();
        }

        public static bool[] CreateEmptyArrayOfBooleans()
        {
            return Array.Empty<bool>();
        }

        public static string[] CreateEmptyArrayOfStrings()
        {
            return Array.Empty<string>();
        }

        public static char[] CreateEmptyArrayOfCharacters()
        {
            return Array.Empty<char>();
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            return Array.Empty<double>();
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            return Array.Empty<float>();
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            return Array.Empty<decimal>();
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            int[] result = new int[10];
            return result;
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            bool[] result = new bool[20];
            return result;
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            string[] result = new string[5];
            return result;
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            char[] result = new char[15];
            return result;
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            double[] result = new double[18];
            return result;
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            float[] result = new float[100];
            return result;
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            decimal[] result = new decimal[1000];
            return result;
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            int[] result = { 123456 };
            return result;
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            int[] result = new int[2] { 1111111, 9999999 };
            return result;
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            int[] result = { 0, 4234, 3845, 2942, 1104, 9794, 923943, 7537, 4162, 10134 };
            return result;
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            bool[] result = { true };
            return result;
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            bool[] result = { true, false, true, false, true };
            return result;
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            bool[] result = { false, true, true, false, true, true, false };
            return result;
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            string[] result = { "one" };
            return result;
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            string[] result = { "one", "two", "three" };
            return result;
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            string[] result = { "one", "two", "three", "four", "five", "six" };
            return result;
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            char[] result = { 'a' };
            return result;
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            char[] result = { 'a', 'b', 'c' };
            return result;
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            char[] result = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };
            return result;
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            double[] result = { 1.12 };
            return result;
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            double[] result = { 1.12, 2.23, 3.34, 4.45, 5.56 };
            return result;
        }

        public static double[] CreateDoubleWithNineElements()
        {
            double[] result = { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };
            return result;
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            float[] result = new[] { 123_456_789.123_456F };
            return result;
        }

        public static float[] CreateFloatWithThreeElements()
        {
            float[] result = new[] { 1_000_000.123_456F, 2_223_334_444.123_456F, 9_999.999_999F };
            return result;
        }

        public static float[] CreateFloatWithFiveElements()
        {
            float[] result = new[] { 1.0_123F, 20.012345F, 300.01234567F, 4_000.01234567F, 500_000.01234567F };
            return result;
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            decimal[] result = new[] { 10_000.123456M };
            return result;
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            decimal[] result = new[] { 1_000.1234M, 100_000.2345M, 100_000.3456M, 1_000_000.456789M, 10_000_000.5678901M };
            return result;
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
            decimal[] result = new[] { 10.122112M, 200.233223M, 3_000.344334M, 40_000.455445M, 500_000.566556M, 6_000_000.677667M, 70_000_000.788778M, 800_000_000.899889M, 9_000_000_000.911991M };
            return result;
        }
    }
}
