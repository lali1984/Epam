using NUnit.Framework;

#pragma warning disable CA1707

namespace CreatingMethods.Tests
{
    [TestFixture]
    public class MethodsWithOutParametersTests
    {
        [Test]
        public void ReturnValues_ReturnBooleans()
        {
            MethodsWithOutParameters.ReturnValues(out bool trueValue, out var falseValue);

            Assert.AreEqual(true, trueValue);
            Assert.AreEqual(false, falseValue);
        }

        [Test]
        public void ReturnValues_ReturnLowercaseUppercaseChars()
        {
            MethodsWithOutParameters.ReturnValues(out char lowerCaseA, out char upperCaseA);

            Assert.AreEqual('a', lowerCaseA);
            Assert.AreEqual('A', upperCaseA);
        }

        [Test]
        public void ReturnValues_ReturnMinMaxFloats()
        {
            MethodsWithOutParameters.ReturnValues(out float minFloatValue, out float maxFloatValue);

            Assert.AreEqual(float.MinValue, minFloatValue);
            Assert.AreEqual(float.MaxValue, maxFloatValue);
        }

        [Test]
        public void ReturnValues_ReturnMinMaxIntegers()
        {
            MethodsWithOutParameters.ReturnValues(out int minIntValue, out int maxIntValue);

            Assert.AreEqual(int.MinValue, minIntValue);
            Assert.AreEqual(int.MaxValue, maxIntValue);
        }

        [Test]
        public void ReturnValues_ReturnMinMaxLongIntegers()
        {
            MethodsWithOutParameters.ReturnValues(out long minLongValue, out long maxLongValue);

            Assert.AreEqual(long.MinValue, minLongValue);
            Assert.AreEqual(long.MaxValue, maxLongValue);
        }
    }
}
