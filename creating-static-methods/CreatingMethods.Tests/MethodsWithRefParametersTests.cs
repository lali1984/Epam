using NUnit.Framework;

#pragma warning disable CA1707

namespace CreatingMethods.Tests
{
    [TestFixture]
    public class MethodsWithRefParametersTests
    {
        [TestCase(true, ExpectedResult = true)]
        [TestCase(false, ExpectedResult = false)]
        public bool ReturnParameterValueAndSetParameterToDefaultValue_ReturnsBoolean(bool boolValue)
        {
            bool result = MethodsWithRefParameters.ReturnParameterValueAndSetParameterToDefaultValue(boolValue: ref boolValue);

            Assert.AreEqual(default(bool), boolValue);

            return result;
        }

        [TestCase('a', ExpectedResult = 'a')]
        [TestCase('A', ExpectedResult = 'A')]
        [TestCase('z', ExpectedResult = 'z')]
        [TestCase('Z', ExpectedResult = 'Z')]
        public char ReturnParameterValueAndSetParameterToDefaultValue_ReturnsChar(char charValue)
        {
            char result = MethodsWithRefParameters.ReturnParameterValueAndSetParameterToDefaultValue(charValue: ref charValue);

            Assert.AreEqual(default(char), charValue);

            return result;
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(0.01f, ExpectedResult = 0.01f)]
        [TestCase(-0.01f, ExpectedResult = -0.01f)]
        [TestCase(float.MinValue, ExpectedResult = float.MinValue)]
        [TestCase(float.MaxValue, ExpectedResult = float.MaxValue)]
        public float ReturnParameterValueAndSetParameterToDefaultValue_ReturnsFloat(float floatValue)
        {
            float result = MethodsWithRefParameters.ReturnParameterValueAndSetParameterToDefaultValue(floatValue: ref floatValue);

            Assert.AreEqual(default(float), floatValue);

            return result;
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(-1, ExpectedResult = -1)]
        [TestCase(int.MinValue, ExpectedResult = int.MinValue)]
        [TestCase(int.MaxValue, ExpectedResult = int.MaxValue)]
        public int ReturnParameterValueAndSetParameterToDefaultValue_ReturnsInt(int intValue)
        {
            int result = MethodsWithRefParameters.ReturnParameterValueAndSetParameterToDefaultValue(intValue: ref intValue);

            Assert.AreEqual(default(int), intValue);

            return result;
        }

        [TestCase(0L, ExpectedResult = 0L)]
        [TestCase(1L, ExpectedResult = 1L)]
        [TestCase(-1L, ExpectedResult = -1L)]
        [TestCase(long.MinValue, ExpectedResult = long.MinValue)]
        [TestCase(long.MaxValue, ExpectedResult = long.MaxValue)]
        public long ReturnParameterValueAndSetParameterToDefaultValue_ReturnsLong(long longValue)
        {
            long result = MethodsWithRefParameters.ReturnParameterValueAndSetParameterToDefaultValue(longValue: ref longValue);

            Assert.AreEqual(default(long), longValue);

            return result;
        }
    }
}
