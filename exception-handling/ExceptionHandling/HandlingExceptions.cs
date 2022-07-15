using System;

namespace ExceptionHandling
{
    public static class HandlingExceptions
    {
        public static bool CatchException(object obj)
        {
            try
            {
                ThrowException(obj);
            }
            catch
            {
                return true;
            }

            return false;
        }

        public static bool CatchArgumentNullException(object obj, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            try
            {
                ThrowException(obj);
            }
            catch
            {
                exceptionMessage = "obj is null. (Parameter 'obj')";
                return true;
            }

            return false;
        }

        public static bool CatchArgumentException(int i, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;
            try
            {
                ThrowException(new object(), i);
            }
            catch
            {
                exceptionMessage = "i parameter is invalid. (Parameter 'i')";
                return true;
            }

            return false;
        }

        public static bool CatchArgumentOutOfRangeException(int j, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;
            try
            {
                ThrowException(new object(), 1, j);
            }
            catch
            {
                exceptionMessage = "j is out of range. (Parameter 'j')";
                return true;
            }

            return false;
        }

        public static bool CatchExceptions(object obj, int i, int j, bool throwException, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            try
            {
                ThrowException(obj, i, j, throwException);
            }
            catch
            {
                if (obj == null)
                {
                    exceptionMessage = "obj is null. (Parameter 'obj')";
                }
                else if (i == 0)
                {
                    exceptionMessage = "i parameter is invalid. (Parameter 'i')";
                }
                else if (j < 0 || j > 10)
                {
                    exceptionMessage = "j is out of range. (Parameter 'j')";
                }
                else if (throwException)
                {
                    exceptionMessage = "exception is thrown.";
                }

                return true;
            }

            return false;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2201:Не порождайте исключения зарезервированных типов", Justification = "<Ожидание>")]
        private static void ThrowException(object obj, int i = 1, int j = 1, bool throwException = false)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj), "obj is null.");
            }

            if (i == 0)
            {
                throw new ArgumentException("i parameter is invalid.", nameof(i));
            }

            if (j < 0 || j > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(j), "j is out of range.");
            }

            if (throwException)
            {
                throw new ArgumentException("exception is thrown.");
            }
        }
    }
}
