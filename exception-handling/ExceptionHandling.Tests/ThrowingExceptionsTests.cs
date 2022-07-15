using System;
using NUnit.Framework;

#pragma warning disable CA1707

namespace ExceptionHandling.Tests
{
    [TestFixture]
    public sealed class ThrowingExceptionsTests
    {
        [TestCase("string")]
        public void CheckParameterAndThrowException_ParameterIsNotNull_ReturnsWithoutException(object obj)
        {
            ThrowingExceptions.CheckParameterAndThrowException(obj);
        }

        [TestCase(null)]
        public void CheckParameterAndThrowException_ParameterIsNull_ThrowsArgumentNullException(object obj)
        {
            Assert.Throws<ArgumentNullException>(() => ThrowingExceptions.CheckParameterAndThrowException(obj), "ThrowingExceptions.CheckParameterAndThrowException should throw an ArgumentNullException.");
        }

        [TestCase("string", "string")]
        public void CheckBothParametersAndThrowException_ParametersAreNotNull_ReturnsWithoutException(object obj1, object obj2)
        {
            ThrowingExceptions.CheckBothParametersAndThrowException(obj1, obj2);
        }

        [TestCase("string", null)]
        [TestCase(null, "string")]
        [TestCase(null, null)]
        public void CheckBothParametersAndThrowException_ParameterIsNull_ThrowsArgumentNullException(object obj1, object obj2)
        {
            Assert.Throws<ArgumentNullException>(() => ThrowingExceptions.CheckBothParametersAndThrowException(obj1, obj2), "ThrowingExceptions.CheckBothParametersAndThrowException should throw an ArgumentNullException.");
        }

        [TestCase("string", ExpectedResult = "string")]
        public string CheckStringAndThrowException_ParameterIsNotNullOrEmpty_ReturnWithoutException(string str)
        {
            return ThrowingExceptions.CheckStringAndThrowException(str);
        }

        [TestCase(null)]
        [TestCase("")]
        public void CheckStringAndThrowException_ParameterIsNullOrEmpty_ThrowsArgumentNullException(string str)
        {
            Assert.Throws<ArgumentNullException>(() => ThrowingExceptions.CheckStringAndThrowException(str), "ThrowingExceptions.CheckStringAndThrowException should throw an ArgumentNullException.");
        }

        [TestCase("string", "string", ExpectedResult = "stringstring")]
        public string CheckBothStringsAndThrowException_ParameterIsNotNullOrEmpty_ReturnWithoutException(string str1, string str2)
        {
            return ThrowingExceptions.CheckBothStringsAndThrowException(str1, str2);
        }

        [TestCase("string", null)]
        [TestCase(null, "string")]
        [TestCase(null, null)]
        public void CheckBothStringsAndThrowException_ParameterIsNullOrEmpty_ThrowsArgumentNullException(string str1, string str2)
        {
            Assert.Throws<ArgumentNullException>(() => ThrowingExceptions.CheckBothStringsAndThrowException(str1, str2), "ThrowingExceptions.CheckBothStringsAndThrowException should throw an ArgumentNullException.");
        }

        [TestCase(2, ExpectedResult = 2)]
        [TestCase(4, ExpectedResult = 4)]
        public int CheckEvenNumberAndThrowException_ParameterIsEven_ReturnWithoutException(int evenNumber)
        {
            return ThrowingExceptions.CheckEvenNumberAndThrowException(evenNumber);
        }

        [TestCase(1)]
        [TestCase(3)]
        public void CheckEvenNumberAndThrowException_ParameterIsNotEven_ThrowsException(int evenNumber)
        {
            Assert.Throws<ArgumentException>(() => ThrowingExceptions.CheckEvenNumberAndThrowException(evenNumber), "ThrowingExceptions.CheckEvenNumberAndThrowException should throw a ArgumentException.");
        }

        [TestCase(16, true, ExpectedResult = 16)]
        [TestCase(16, false, ExpectedResult = 16)]
        [TestCase(17, true, ExpectedResult = 17)]
        [TestCase(17, false, ExpectedResult = 17)]
        [TestCase(58, true, ExpectedResult = 58)]
        [TestCase(63, false, ExpectedResult = 63)]
        public int CheckCandidateAgeAndThrowException_ParameterIsInRange_ReturnWithoutException(int candidateAge, bool isCandidateWoman)
        {
            return ThrowingExceptions.CheckCandidateAgeAndThrowException(candidateAge, isCandidateWoman);
        }

        [TestCase(-1, true)]
        [TestCase(-1, false)]
        [TestCase(0, true)]
        [TestCase(0, false)]
        [TestCase(1, true)]
        [TestCase(1, false)]
        [TestCase(15, true)]
        [TestCase(15, false)]
        [TestCase(59, true)]
        [TestCase(64, false)]
        public void CheckCandidateAgeAndThrowException_ParameterIsOutOfRange_ThrowsException(int candidateAge, bool isCandidateWoman)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ThrowingExceptions.CheckCandidateAgeAndThrowException(candidateAge, isCandidateWoman));
        }

        [TestCase(1, 1, "alison", ExpectedResult = "alison-11")]
        [TestCase(1, 2, "wilson", ExpectedResult = "wilson-12")]
        [TestCase(2, 2, "smith", ExpectedResult = "smith-22")]
        [TestCase(31, 12, "debby", ExpectedResult = "debby-3112")]
        public string GenerateUserCode_ParametersAreCorrect_ReturnUserCode(int day, int month, string username)
        {
            return ThrowingExceptions.GenerateUserCode(day, month, username);
        }

        [TestCase(-1, 1, "alison")]
        [TestCase(1, -1, "alison")]
        [TestCase(32, 1, "alison")]
        [TestCase(1, 13, "alison")]
        public void GenerateUserCode_DayAndMonthParametersAreIncorrect_ThrowsException(int day, int month, string username)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ThrowingExceptions.GenerateUserCode(day, month, username), "ThrowingExceptions.GenerateUserCode should throw an ArgumentOutOfRangeException.");
        }

        [TestCase(1, 1, null)]
        [TestCase(1, 1, "")]
        [TestCase(31, 12, null)]
        [TestCase(31, 12, "")]
        public void GenerateUserCode_UsernameParameterIsIncorrect_ThrowsException(int day, int month, string username)
        {
            Assert.Throws<ArgumentNullException>(() => ThrowingExceptions.GenerateUserCode(day, month, username), "ThrowingExceptions.GenerateUserCode should throw an ArgumentNullException.");
        }
    }
}
