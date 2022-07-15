using NUnit.Framework;

#pragma warning disable CA1707

namespace ExceptionHandling.Tests
{
    [TestFixture]
    public class HandlingExceptionsTests
    {
        [TestCase("string", ExpectedResult = false)]
        [TestCase(null, ExpectedResult = true)]
        public bool CatchException_ReturnsBoolean(object obj)
        {
            return HandlingExceptions.CatchException(obj);
        }

        [TestCase("string", false, "")]
        [TestCase(null, true, "obj is null. (Parameter 'obj')")]
        public void CatchArgumentNullException_ReturnsBool(object obj, bool expectedResult, string expectedExceptionMessage)
        {
            var result = HandlingExceptions.CatchArgumentNullException(obj, out string exceptionMessage);

            Assert.AreEqual(expectedResult, result);
            Assert.AreEqual(expectedExceptionMessage, exceptionMessage);
        }

        [TestCase(-1, false, "")]
        [TestCase(1, false, "")]
        [TestCase(0, true, "i parameter is invalid. (Parameter 'i')")]
        public void CatchArgumentException_ReturnsBool(int i, bool expectedResult, string expectedExceptionMessage)
        {
            var result = HandlingExceptions.CatchArgumentException(i, out string exceptionMessage);

            Assert.AreEqual(expectedResult, result);
            Assert.AreEqual(expectedExceptionMessage, exceptionMessage);
        }

        [TestCase(-1, true, "j is out of range. (Parameter 'j')")]
        [TestCase(0, false, "")]
        [TestCase(1, false, "")]
        [TestCase(10, false, "")]
        [TestCase(11, true, "j is out of range. (Parameter 'j')")]
        public void CatchArgumentOutOfRangeException_ReturnsBool(int j, bool expectedResult, string expectedExceptionMessage)
        {
            var result = HandlingExceptions.CatchArgumentOutOfRangeException(j, out string exceptionMessage);

            Assert.AreEqual(expectedResult, result);
            Assert.AreEqual(expectedExceptionMessage, exceptionMessage);
        }

        [TestCase("string", 1, 1, false, false, "")]
        [TestCase(null, 1, 1, false, true, "obj is null. (Parameter 'obj')")]
        [TestCase("string", 0, 1, false, true, "i parameter is invalid. (Parameter 'i')")]
        [TestCase("string", 1, -1, false, true, "j is out of range. (Parameter 'j')")]
        [TestCase("string", 1, 11, false, true, "j is out of range. (Parameter 'j')")]
        [TestCase("string", 1, 1, true, true, "exception is thrown.")]
        public void CatchExceptions_ReturnsBool(object obj, int i, int j, bool throwException, bool expectedResult, string expectedExceptionMessage)
        {
            var result = HandlingExceptions.CatchExceptions(obj, i, j, throwException, out string exceptionMessage);

            Assert.AreEqual(expectedResult, result);
            Assert.AreEqual(expectedExceptionMessage, exceptionMessage);
        }
    }
}
