using System;
using System.Collections.Generic;

namespace LouVuiDateCode
{
    public static class CountryParser
    {
        /// <summary>
        /// Gets a an array of <see cref="Country"/> enumeration values for a specified factory location code. One location code can belong to many countries.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <returns>An array of <see cref="Country"/> enumeration values.</returns>
        public static Country[] GetCountry(string factoryLocationCode)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            string[][] codeFactory = new string[6][];
            codeFactory[0] = new string[]
            {
                "A0", "A1", "A2", "AA", "AAS", "AH", "AN", "AR",
                "AS", "BA", "BJ", "BU", "DR", "DU", "DR", "DT",
                "CO", "CT", "CX", "ET", "FL", "LW", "MB", "MI",
                "NO", "RA", "RI", "SA", "SD", "SF", "SL", "SN",
                "SP", "SR", "TA", "TJ", "TH", "TN", "TR", "TS",
                "VI", "VX",
            };
            codeFactory[1] = new string[] { "LP", "OL" };
            codeFactory[2] = new string[]
            {
                "BC", "BO", "CE", "FO", "MA", "NZ", "OB", "PL",
                "RC", "RE", "SA", "TD",
            };
            codeFactory[3] = new string[]
            {
                "BC", "CA", "LO", "LB", "LM", "LW", "GI", "UB",
            };
            codeFactory[4] = new string[] { "DI", "FA" };
            codeFactory[5] = new string[]
            {
                "FC", "FH", "LA", "OS", "SD", "FL", "TX",
            };
            List<Country> countryLocation = new List<Country>();

            foreach (string[] country in codeFactory)
            {
                foreach (string code in country)
                {
                    if (code == factoryLocationCode)
                    {
                        int n = Array.IndexOf(codeFactory, country);
                        countryLocation.Add((Country)n);
                    }
                }
            }

            return countryLocation.ToArray();
        }
    }
}
