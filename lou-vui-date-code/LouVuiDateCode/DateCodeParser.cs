using System;
using System.Globalization;

namespace LouVuiDateCode
{
    public static class DateCodeParser
    {
        /// <summary>
        /// Parses a date code and returns a <see cref="manufacturingYear"/> and <see cref="manufacturingMonth"/>.
        /// </summary>
        /// <param name="dateCode">A three or four number date code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void ParseEarly1980Code(string dateCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length < 3 || dateCode.Length > 4)
            {
                throw new ArgumentException("dateCode is not valid.");
            }

            string manufacturing = "19" + dateCode[..2];

            manufacturingYear = uint.Parse(manufacturing, CultureInfo.InvariantCulture);
            manufacturingMonth = uint.Parse(dateCode[2..], CultureInfo.InvariantCulture);

            if (manufacturingMonth == 0 || manufacturingMonth > 12)
            {
                throw new ArgumentException("dateCode is not valid.");
            }

            if (manufacturingYear < 1980 || manufacturingYear > 1989)
            {
                throw new ArgumentException("dateCode is not valid.");
            }
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingMonth"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A three or four number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void ParseLate1980Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length < 5 || dateCode.Length > 6)
            {
                throw new ArgumentException("dateCode is not valid.");
            }

            string manufacturing = "19" + dateCode[..2];
            manufacturingYear = uint.Parse(manufacturing, CultureInfo.InvariantCulture);
            manufacturingMonth = uint.Parse(dateCode[2..^2], CultureInfo.InvariantCulture);
            factoryLocationCode = dateCode[^2..];

            if (manufacturingMonth == 0 || manufacturingMonth > 12)
            {
                throw new ArgumentException("dateCode is not valid.");
            }

            if (manufacturingYear < 1985 || manufacturingYear >= 1990)
            {
                throw new ArgumentException("dateCode is not valid.");
            }

            factoryLocationCountry = CountryParser.GetCountry(factoryLocationCode);
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingMonth"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A six number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void Parse1990Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length != 6)
            {
                throw new ArgumentException("dateCode is not valid.");
            }

            string year;
            year = dateCode[3] switch
            {
                '9' => "19" + dateCode[3] + dateCode[5],
                _ => "20" + dateCode[3] + dateCode[5],
            };

            string month = $"{dateCode[2]}" + dateCode[4];

            manufacturingYear = uint.Parse(year, CultureInfo.InvariantCulture);
            manufacturingMonth = uint.Parse(month, CultureInfo.InvariantCulture);
            factoryLocationCode = dateCode[..2];

            if (manufacturingMonth == 0 || manufacturingMonth > 12)
            {
                throw new ArgumentException("dateCode is not valid.");
            }

            if (manufacturingYear <= 1989 || manufacturingYear >= 2007)
            {
                throw new ArgumentException("dateCode is not valid.");
            }

            factoryLocationCountry = CountryParser.GetCountry(factoryLocationCode);
            if (factoryLocationCountry.Length == 0)
            {
                throw new ArgumentException("dateCode is not valid.");
            }
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingWeek"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A six number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingWeek">A manufacturing week to return.</param>
        public static void Parse2007Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingWeek)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length != 6)
            {
                throw new ArgumentException("dateCode is not valid.");
            }

            string year = "20" + dateCode[3] + dateCode[5];
            string week = $"{dateCode[2]}" + dateCode[4];

            manufacturingYear = uint.Parse(year, CultureInfo.InvariantCulture);
            manufacturingWeek = uint.Parse(week, CultureInfo.InvariantCulture);
            factoryLocationCode = dateCode[..2];
            DateTime dateStart = new DateTime(2007, 01, 01);
            DateTime dateTime;
            int endYearWeek = ISOWeek.GetWeeksInYear((int)manufacturingYear);
            try
            {
                dateTime = ISOWeek.ToDateTime((int)manufacturingYear, (int)manufacturingWeek, DayOfWeek.Monday);
            }
            catch (Exception)
            {
                throw new ArgumentException("dateCode is not valid");
            }

            if (dateTime < dateStart)
            {
                throw new ArgumentException("dateCode is not valid");
            }

            if ((int)manufacturingWeek > endYearWeek)
            {
                throw new ArgumentException("dateCode is not valid");
            }

            factoryLocationCountry = CountryParser.GetCountry(factoryLocationCode);
            if (factoryLocationCountry.Length == 0)
            {
                throw new ArgumentException("dateCode is not valid.");
            }
        }
    }
}
