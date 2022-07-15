using System;
using System.Linq;
using NUnit.Framework;
using static FilterTask.ArrayExtension;

#pragma warning disable CA1707

namespace FilterTask.Tests
{ 
    public class ArrayExtensionTests
    {
        [Category("Successful tests.")]
        [TestCase(new[] { 2212332, 1405644, -1236674 }, 0, ExpectedResult = new[] { 1405644 })]
        [TestCase(new[] { 53, 71, -24, 1001, 32, 1005 }, 2, ExpectedResult = new[] { -24, 32 })]
        [TestCase(new[] { -27, 173, 371132, 7556, 7243, 10017 }, 7, ExpectedResult = new[] { -27, 173, 371132, 7556, 7243, 10017 })]
        [TestCase(new[] { 7, 2, 5, 5, -1, -1, 2 }, 9, ExpectedResult = new int[0])]
        [TestCase(new[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, 7, ExpectedResult = new int[] { 7, 7, 70, 17 })]
        [TestCase(new[] { -123, 123, 2202, 3333, 4444, 55055, 0, -7, 5402, 9, 0, -150, 287 }, 0, ExpectedResult = new int[] { 2202, 55055, 0, 5402, 0, -150 })]
        [TestCase(new[] { -123, 123, 2202, 3333, 4444, 55055, 0, -7, 5402, 9, 0, -150, 287 }, 2, ExpectedResult = new int[] { -123, 123, 2202, 5402, 287 })]
        [TestCase(new[] { -583, -7481, -24, -81001, -32, -10805 }, 8, ExpectedResult = new[] { -583, -7481, -81001, -10805 })]
        [TestCase(new[] { 111, 111, 111, 11111111 }, 1, ExpectedResult = new[] { 111, 111, 111, 11111111 })]
        [TestCase(new[] { 111, 111, 111, 11111111 }, 5, ExpectedResult = new int[0])]
        [TestCase(new[] { -1, 0, 111, -11, -1 }, 1, ExpectedResult = new int[] { -1, 111, -11, -1 })]
        [TestCase(new[] { 0, 0, 0, 0, 0 }, 5, ExpectedResult = new int[0] { })]
        [TestCase(new[] { 0, 0, 0, 0, 0 }, 0, ExpectedResult = new int[] { 0, 0, 0, 0, 0 })]
        public int[] FilterByDigit_WithCorrectDigits_ReturnNewArray(int[] array, int digit) => FilterByDigit(array, digit);

        [Test]
        [Category("Exception tests.")]
        public void FilterByDigit_ArrayIsEmpty_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => FilterByDigit(Array.Empty<int>(), 0), "Array can not be empty.");

        [Test]
        [Category("Exception tests.")]
        public void FilterByDigit_ArrayIsNull_ThrowArgumentNullException() => Assert.Throws<ArgumentNullException>(
            () => FilterByDigit(null, 0), "Array can not be null.");

        [Test]
        [Category("Exception tests.")]
        public void FilterByDigit_DigitLessZero_ThrowArgumentOutOfRangeException() => Assert.Throws<ArgumentOutOfRangeException>(
            () => FilterByDigit(new int[] { 1, 2 }, -1), "Expected digit can not be less than zero.");

        [Test]
        [Category("Exception tests.")]
        public void FilterByDigit_DigitMoreThanNine_ThrowArgumentOutOfRangeException() => Assert.Throws<ArgumentOutOfRangeException>(
            () => FilterByDigit(new int[] { 1, 2 }, 20), "Expected digit can not be more than nine.");

        [Test]
        [Category("Performance tests.")]
        public void FilterByDigit_PerformanceTest()
        {
            int sourceLength = 100_000_000;
            int digit = 8;
            int[] source = new int[sourceLength];
            int count = 5, step = sourceLength / count;
            for (int i = 0; i < sourceLength; i += step)
            {
                source[i] = digit;
            }  

            int[] expected = Enumerable.Repeat(digit, count).ToArray();
            
            int[] actual = FilterByDigit(source, digit);
            
            CollectionAssert.AreEqual(expected, actual);
         } 
     } 
 } 