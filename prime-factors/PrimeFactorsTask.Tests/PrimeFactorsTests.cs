using System;
using NUnit.Framework;

#pragma warning disable CA1707

namespace PrimeFactorsTask.Tests
{
    public class PrimeFactorsTests
    {
        [TestCase(1, ExpectedResult = new int[] { })]
        [TestCase(2, ExpectedResult = new[] { 2 })]
        [TestCase(9, ExpectedResult = new[] { 3, 3 })]
        [TestCase(8, ExpectedResult = new[] { 2, 2, 2 })]
        [TestCase(12, ExpectedResult = new[] { 2, 2, 3 })]
        [TestCase(901255, ExpectedResult = new[] { 5, 17, 23, 461 })]
        [TestCase(342324, ExpectedResult = new[] { 2, 2, 3, 3, 37, 257 })]
        public int[] GetFactors_ReturnsPrimeFactors(int number)
        {
            return PrimeFactors.GetFactors(number);
        }

        [TestCase(-100)]
        [TestCase(-1)]
        [TestCase(0)]
        public void GetFactors_IfNumberLessOrEqualsZero_ThrowArgumentException(int number)
            => Assert.Throws<ArgumentException>(
                () => PrimeFactors.GetFactors(number), $"{number} cannot be less or equals zero.");
    }
}
