using System;
using System.Globalization;

namespace LouVuiDateCode
{
    public static class DateCodeGenerator
    {
        /// <summary>
        /// Generates a date code using rules from early 1980s.
        /// </summary>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateEarly1980Code(uint manufacturingYear, uint manufacturingMonth)
        {
            if (manufacturingYear < 1980 || manufacturingYear >= 1990)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingMonth > 12 || manufacturingYear == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth));
            }

            string year = string.Concat(manufacturingYear);
            string month = string.Concat(manufacturingMonth);
            return year[2..] + month;
        }

        /// <summary>
        /// Generates a date code using rules from early 1980s.
        /// </summary>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateEarly1980Code(DateTime manufacturingDate)
        {
            CultureInfo info = new CultureInfo("en-US");
            if (DateTime.Parse("01/01/1990 00:00:00", info) <= manufacturingDate || DateTime.Parse("01 / 01 / 1980 00:00:00", info) > manufacturingDate)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            return manufacturingDate.ToString("yyM", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Generates a date code using rules from late 1980s.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateLate1980Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (factoryLocationCode.Length != 2 || !char.IsLetter(factoryLocationCode[0]) || !char.IsLetter(factoryLocationCode[1]))
            {
                throw new ArgumentException("FactoryLocationCode is not correct.");
            }

            if (manufacturingYear < 1980 || manufacturingYear >= 1990)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingMonth > 12 || manufacturingMonth == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth));
            }

            string month = string.Concat(manufacturingMonth);
            string year = string.Concat(manufacturingYear);

            return year[2..] + month + factoryLocationCode.ToUpper(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Generates a date code using rules from late 1980s.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateLate1980Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (factoryLocationCode.Length != 2 || !char.IsLetter(factoryLocationCode[0]) || !char.IsLetter(factoryLocationCode[1]))
            {
                throw new ArgumentException("FactoryLocationCode is not correct.");
            }

            if (DateTime.Parse("01/01/1990 00:00:00", CultureInfo.InvariantCulture) <= manufacturingDate || DateTime.Parse("01 / 01 / 1980 00:00:00", CultureInfo.InvariantCulture) > manufacturingDate)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            return manufacturingDate.ToString("yyM", CultureInfo.InvariantCulture) + factoryLocationCode.ToUpper(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Generates a date code using rules from 1990 to 2006 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate1990Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (factoryLocationCode.Length != 2 || !char.IsLetter(factoryLocationCode[0]) || !char.IsLetter(factoryLocationCode[1]))
            {
                throw new ArgumentException("FactoryLocationCode is not correct.");
            }

            if (manufacturingYear < 1990 || manufacturingYear >= 2007)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingMonth > 12 || manufacturingMonth == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth));
            }

            DateTime dateStr = new DateTime((int)manufacturingYear, (int)manufacturingMonth, 01, 00, 00, 00);
            string date = dateStr.ToString("yyMM", CultureInfo.InvariantCulture);

            return factoryLocationCode.ToUpper(CultureInfo.InvariantCulture) + date[2] + date[0] + date[3] + date[1];
        }

        /// <summary>
        /// Generates a date code using rules from 1990 to 2006 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate1990Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (factoryLocationCode.Length != 2 || !char.IsLetter(factoryLocationCode[0]) || !char.IsLetter(factoryLocationCode[1]))
            {
                throw new ArgumentException("FactoryLocationCode is not correct.");
            }

            if (DateTime.Parse("01/01/2007 00:00:00", CultureInfo.InvariantCulture) <= manufacturingDate || DateTime.Parse("01 / 01 / 1990 00:00:00", CultureInfo.InvariantCulture) > manufacturingDate)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            string date = manufacturingDate.ToString("yyMM", CultureInfo.InvariantCulture);
            return factoryLocationCode.ToUpper(CultureInfo.InvariantCulture) + date[2] + date[0] + date[3] + date[1];
        }

        /// <summary>
        /// Generates a date code using rules from post 2007 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingWeek">A manufacturing week number.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate2007Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingWeek)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            DateTime dateStart = new DateTime(2007, 01, 01);
            DateTime dateTime;
            int endYearWeek = ISOWeek.GetWeeksInYear((int)manufacturingYear);
            try
            {
                dateTime = ISOWeek.ToDateTime((int)manufacturingYear, (int)manufacturingWeek, DayOfWeek.Monday);
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingWeek));
            }

            if (dateTime < dateStart)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingWeek));
            }

            if ((int)manufacturingWeek > endYearWeek)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingWeek));
            }

            if (factoryLocationCode.Length != 2 || !char.IsLetter(factoryLocationCode[0]) || !char.IsLetter(factoryLocationCode[1]))
            {
                throw new ArgumentException("FactoryLocationCode is not correct.");
            }

            string date = manufacturingYear.ToString(CultureInfo.InvariantCulture)[2..] + manufacturingWeek.ToString("00", CultureInfo.InvariantCulture);
            return factoryLocationCode.ToUpper(CultureInfo.InvariantCulture) + date[2] + date[0] + date[3] + date[1];
        }

        /// <summary>
        /// Generates a date code using rules from post 2007 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate2007Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (factoryLocationCode.Length != 2 || !char.IsLetter(factoryLocationCode[0]) || !char.IsLetter(factoryLocationCode[1]))
            {
                throw new ArgumentException("FactoryLocationCode is not correct.");
            }

            DateTime dateStart = new DateTime(2007, 01, 01);
            int week = ISOWeek.GetWeekOfYear(manufacturingDate);
            int year = ISOWeek.GetYear(manufacturingDate);
            if (manufacturingDate < dateStart)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            string date = year.ToString(CultureInfo.InvariantCulture)[2..] + week.ToString("00", CultureInfo.InvariantCulture);
            return factoryLocationCode.ToUpper(CultureInfo.InvariantCulture) + date[2] + date[0] + date[3] + date[1];
        }
    }
}
