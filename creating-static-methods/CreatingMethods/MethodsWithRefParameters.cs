namespace CreatingMethods
{
    public static class MethodsWithRefParameters
    {
        public static bool ReturnParameterValueAndSetParameterToDefaultValue(ref bool boolValue)
        {
            bool value = boolValue;
            boolValue = default(bool);
            return value;
        }

        public static char ReturnParameterValueAndSetParameterToDefaultValue(ref char charValue)
        {
            char value = charValue;
            charValue = default(char);
            return value;
        }

        public static float ReturnParameterValueAndSetParameterToDefaultValue(ref float floatValue)
        {
            float value = floatValue;
            floatValue = default(float);
            return value;
        }

        public static int ReturnParameterValueAndSetParameterToDefaultValue(ref int intValue)
        {
            int value = intValue;
            intValue = default(int);
            return value;
        }

        public static long ReturnParameterValueAndSetParameterToDefaultValue(ref long longValue)
        {
            long value = longValue;
            longValue = default(long);
            return value;
        }
    }
}
