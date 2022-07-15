using System.Collections.Generic;
using NUnit.Framework;

namespace RgbConverter.Tests
{
    public class RgbTests
    {
        private static IEnumerable<TestCaseData> TestCaseData
        {
            get
            {
                yield return new TestCaseData(255, 255, 255, "FFFFFF", string.Empty);
                yield return new TestCaseData(255, 255, 300, "FFFFFF", string.Empty);
                yield return new TestCaseData(0, 0, 0, "000000", string.Empty);
                yield return new TestCaseData(148, -20, 211, "9400D3", "Handle negative numbers.");
                yield return new TestCaseData(144, 195, 212, "90C3D4", string.Empty);
                yield return new TestCaseData(212, 53, 12, "D4350C", "Consider single hex digit numbers.");
            }
        }
        
        [TestCaseSource(nameof(TestCaseData))]
        public void GetHexRepresentationTests(int red, int green, int blue, string expected, string message)
        {
            Assert.AreEqual(expected, Rgb.GetHexRepresentation(red, green, blue), message);
        }
    }
}
