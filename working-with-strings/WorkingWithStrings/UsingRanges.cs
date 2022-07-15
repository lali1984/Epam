using System;

namespace WorkingWithStrings
{
    public static class UsingRanges
    {
        public static string GetStringWithAllChars(string str)
        {
            return str[..];
        }

        public static string GetStringWithoutFirstChar(string str)
        {
            return str[1..];
        }

        public static string GetStringWithoutTwoFirstChars(string str)
        {
            return str[2..];
        }

        public static string GetStringWithoutThreeFirstChars(string str)
        {
            return str[3..];
        }

        public static string GetStringWithoutLastChar(string str)
        {
            return str[..^1];
        }

        public static string GetStringWithoutTwoLastChars(string str)
        {
            return str[..^2];
        }

        public static string GetStringWithoutThreeLastChars(string str)
        {
            return str[..^3];
        }

        public static string GetStringWithoutFirstAndLastChars(string str)
        {
            return str[1..^1];
        }

        public static string GetStringWithoutTwoFirstAndTwoLastChars(string str)
        {
            return str[2..^2];
        }

        public static string GetStringWithoutThreeFirstAndThreeLastChars(string str)
        {
            return str[3..^3];
        }

        public static void GetProductionCodeDetails(string productionCode, out string regionCode, out string locationCode, out string dateCode, out string factoryCode)
        {
            regionCode = productionCode[..1];
            locationCode = productionCode[3..5];
            dateCode = productionCode[7..10];
            factoryCode = productionCode[^4..];
        }

        public static void GetSerialNumberDetails(string serialNumber, out string countryCode, out string manufacturerCode, out string factoryCode, out string stationCode)
        {
            countryCode = serialNumber[^9..^8];
            manufacturerCode = serialNumber[^8..^6];
            factoryCode = serialNumber[^5..^1];
            stationCode = serialNumber[^1..];
        }
    }
}
