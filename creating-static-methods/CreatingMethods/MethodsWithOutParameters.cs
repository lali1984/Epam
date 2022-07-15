namespace CreatingMethods
{
    public static class MethodsWithOutParameters
    {
        public static void ReturnValues(out bool trueValue, out bool falseValue)
        {
            trueValue = true;
            falseValue = false;
        }

        public static void ReturnValues(out char lowerCaseA, out char upperCaseA)
        {
            lowerCaseA = 'a';
            upperCaseA = 'A';
        }

        public static void ReturnValues(out float minFloatValue, out float maxFloatValue)
        {
            minFloatValue = float.MinValue;
            maxFloatValue = float.MaxValue;
        }

        public static void ReturnValues(out int minIntValue, out int maxIntValue)
        {
            minIntValue = int.MinValue;
            maxIntValue = int.MaxValue;
        }

        public static void ReturnValues(out long minLongValue, out long maxLongValue)
        {
            minLongValue = long.MinValue;
            maxLongValue = long.MaxValue;
        }
    }
}
