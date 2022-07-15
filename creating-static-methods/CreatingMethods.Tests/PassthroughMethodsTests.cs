using NUnit.Framework;

// ReSharper disable once IdentifierTypo
#pragma warning disable CA1707

namespace CreatingMethods.Tests
{
    [TestFixture]
    public class PassthroughMethodsTests
    {
        [TestCase(true, ExpectedResult = true)]
        [TestCase(false, ExpectedResult = false)]
        public bool ReturnValue_ReturnsBoolean(bool argument)
        {
            return PassthroughMethods.ReturnValue(boolValue: argument);
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(byte.MinValue, ExpectedResult = byte.MinValue)]
        [TestCase(byte.MaxValue, ExpectedResult = byte.MaxValue)]
        public byte ReturnValue_ReturnsByte(byte argument)
        {
            return PassthroughMethods.ReturnValue(byteValue: argument);
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(-1, ExpectedResult = -1)]
        [TestCase(sbyte.MinValue, ExpectedResult = sbyte.MinValue)]
        [TestCase(sbyte.MaxValue, ExpectedResult = sbyte.MaxValue)]
        public sbyte ReturnValue_ReturnsSignedByte(sbyte argument)
        {
            return PassthroughMethods.ReturnValue(sbyteValue: argument);
        }

        [TestCase('A', ExpectedResult = 'A')]
        [TestCase('a', ExpectedResult = 'a')]
        [TestCase('Z', ExpectedResult = 'Z')]
        [TestCase('z', ExpectedResult = 'z')]
        public char ReturnValue_ReturnsChar(char argument)
        {
            return PassthroughMethods.ReturnValue(charValue: argument);
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(0.1, ExpectedResult = 0.1)]
        [TestCase(-0.1, ExpectedResult = -0.1)]
        [TestCase(1000.0001, ExpectedResult = 1000.0001)]
        [TestCase(-1000.0001, ExpectedResult = -1000.0001)]
        public decimal ReturnValue_ReturnsDecimal(decimal argument)
        {
            return PassthroughMethods.ReturnValue(decimalValue: argument);
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(0.1, ExpectedResult = 0.1)]
        [TestCase(-0.1, ExpectedResult = -0.1)]
        [TestCase(double.MinValue, ExpectedResult = double.MinValue)]
        [TestCase(double.MaxValue, ExpectedResult = double.MaxValue)]
        [TestCase(double.Epsilon, ExpectedResult = double.Epsilon)]
        [TestCase(double.PositiveInfinity, ExpectedResult = double.PositiveInfinity)]
        [TestCase(double.NegativeInfinity, ExpectedResult = double.NegativeInfinity)]
        [TestCase(double.NaN, ExpectedResult = double.NaN)]
        public double ReturnValue_ReturnsDouble(double argument)
        {
            return PassthroughMethods.ReturnValue(doubleValue: argument);
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(0.1f, ExpectedResult = 0.1f)]
        [TestCase(-0.1f, ExpectedResult = -0.1f)]
        [TestCase(float.MinValue, ExpectedResult = float.MinValue)]
        [TestCase(float.MaxValue, ExpectedResult = float.MaxValue)]
        [TestCase(float.Epsilon, ExpectedResult = float.Epsilon)]
        [TestCase(float.NaN, ExpectedResult = float.NaN)]
        [TestCase(float.PositiveInfinity, ExpectedResult = float.PositiveInfinity)]
        [TestCase(float.NegativeInfinity, ExpectedResult = float.NegativeInfinity)]
        public float ReturnValue_ReturnsFloat(float argument)
        {
            return PassthroughMethods.ReturnValue(floatValue: argument);
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1000, ExpectedResult = 1000)]
        [TestCase(-1000, ExpectedResult = -1000)]
        [TestCase(int.MinValue, ExpectedResult = int.MinValue)]
        [TestCase(int.MaxValue, ExpectedResult = int.MaxValue)]
        public int ReturnValue_ReturnsInteger(int argument)
        {
            return PassthroughMethods.ReturnValue(intValue: argument);
        }

        [TestCase(0u, ExpectedResult = 0u)]
        [TestCase(1u, ExpectedResult = 1u)]
        [TestCase(uint.MinValue, ExpectedResult = uint.MinValue)]
        [TestCase(uint.MaxValue, ExpectedResult = uint.MaxValue)]
        public uint ReturnValue_ReturnsUnsignedInteger(uint argument)
        {
            return PassthroughMethods.ReturnValue(uintValue: argument);
        }

        [TestCase(0L, ExpectedResult = 0L)]
        [TestCase(1L, ExpectedResult = 1L)]
        [TestCase(-1L, ExpectedResult = -1L)]
        [TestCase(long.MinValue, ExpectedResult = long.MinValue)]
        [TestCase(long.MaxValue, ExpectedResult = long.MaxValue)]
        public long ReturnValue_ReturnsLong(long argument)
        {
            return PassthroughMethods.ReturnValue(longValue: argument);
        }

        [TestCase(0ul, ExpectedResult = 0ul)]
        [TestCase(1ul, ExpectedResult = 1ul)]
        [TestCase(ulong.MinValue, ExpectedResult = ulong.MinValue)]
        [TestCase(ulong.MaxValue, ExpectedResult = ulong.MaxValue)]
        public ulong ReturnValue_ReturnsUnsignedLong(ulong argument)
        {
            return PassthroughMethods.ReturnValue(ulongValue: argument);
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(-1, ExpectedResult = -1)]
        [TestCase(short.MinValue, ExpectedResult = short.MinValue)]
        [TestCase(short.MaxValue, ExpectedResult = short.MaxValue)]
        public short ReturnValue_ReturnsShortInteger(short argument)
        {
            return PassthroughMethods.ReturnValue(shortValue: argument);
        }

        [TestCase((ushort)0, ExpectedResult = (ushort)0)]
        [TestCase((ushort)0, ExpectedResult = (ushort)0)]
        [TestCase(ushort.MinValue, ExpectedResult = ushort.MinValue)]
        [TestCase(ushort.MaxValue, ExpectedResult = ushort.MaxValue)]
        public ushort ReturnValue_ReturnsUnsignedShortInteger(ushort argument)
        {
            return PassthroughMethods.ReturnValue(ushortValue: argument);
        }
    }
}
