using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using static ShuffleCharacters.StringExtension;

#pragma warning disable CA1707

namespace ShuffleCharacters.Tests
{
    [TestFixture]
    public class StringExtensionTests
    {
        private static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData("Привет Эпам", 2, "Пепртаи мвЭ");
                yield return new TestCaseData("Hello EPAM!", 2, "HoAe MlE!lP");
                yield return new TestCaseData("Hello EPAM!", 22, "HoAe MlE!lP");
                yield return new TestCaseData("Hello EPAM!", 21, "HloEA!el PM");
            }
        }

        [TestCase("A", 1, ExpectedResult = "A")]
        [TestCase("A", 2, ExpectedResult = "A")]
        [TestCase("AB", 1, ExpectedResult = "AB")]
        [TestCase("AB", 2, ExpectedResult = "AB")]
        [TestCase("AB", 3, ExpectedResult = "AB")]
        [TestCase("123456789", 1, ExpectedResult = "135792468")]
        [TestCase("123456789", 2, ExpectedResult = "159483726")]
        [TestCase("123456789", 3, ExpectedResult = "198765432")]
        [TestCase("123456789", 4, ExpectedResult = "186429753")]
        [TestCase("123456789", 5, ExpectedResult = "162738495")]
        [TestCase("123456789", 6, ExpectedResult = "123456789")]
        [TestCase("123456789", 7, ExpectedResult = "135792468")]
        [TestCase("Das lässt sich nicht ändern.", 10, ExpectedResult = "Drdätcnhi sä anen hi cstsls.")]
        [TestCase("Das lässt sich nicht ändern.", 5, ExpectedResult = "Däsn r thhdasiiänl  tessccn.")]
        [TestCase("1234567890", int.MaxValue, ExpectedResult = "1357924680")]
        [TestCase(
            "Lorem ipsum dolor sit amet consectetur adipisicing elit." +
            " Excepturi laudantium, vel natus fugiat, illum dignissimos" +
            " fuga officia maiores ea at ex quis animi incidunt doloremque, " +
            "dolor quia. Quisquam, veniam hic!", int.MaxValue,
            ExpectedResult = "Ldeodeeamniat e oiaeumsac mtuf a  nua Eiadsn mocav " +
                             "ivsdiau pm rdlirqeinitaei iutigqir  e pis li  ac nus " +
                             "Qteuto egomrp fnittsmqeri uo., ,icuaohr,gn,oass iclalm " +
                             "uieoilfuncnoismudxqlttse itid umuimclii.sxl ougfar!")]
        [TestCase(@"!#%')+-/13579;=?ACEGIKMOQSU""$&(*,.02468:<>@BDFHJLNPRT", 5, ExpectedResult = @"!,7BM#.9DO%0;FQ'2=HS)4?JU+6AL""-8CN$/:EP&1<GR(3>IT*5@K")]
        [TestCase(@"!#%')+-/13579;=?ACEGIKMOQSU""$&(*,.02468:<>@BDFHJLNPRT", 20, ExpectedResult = @"!QLGB=83.)$TOJE@;61,'""RMHC>94/*%UPKFA<72-(#SNID?:50+&")]
        [TestCase(@"!#%')+-/13579;=?ACEGIKMOQSU""$&(*,.02468:<>@BDFHJLNPRT", 955031, ExpectedResult = @"!""#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTU")]
        [TestCase(
            @"!snid_ZUPKFA<72-(#upkfa\WRMHC>94/*%wrmhc^YTOJE@;61,'""toje`[VQLGB=83.)$vqlgb]XSNID?:50+&x",
            2147483637,
            ExpectedResult = @"!/=KYgu,:HVdr)7ESao&4BP^l#1?M[iw.<JXft+9GUcq(6DR`n%3AO]k""0>LZhv-;IWes*8FTbp'5CQ_m$2@N\jx")]
        public string ShuffleCharsTests(string source, int count)
            => ShuffleChars(source, count);

        [Test]
        public void ShuffleChars_IfSourceStringIsNull_ThrowArgumentException()
            => Assert.Throws<ArgumentException>(
                () => ShuffleChars(null, int.MaxValue));

        [Test]
        public void ShuffleChars_IfSourceStringIsEmpty_ThrowArgumentException()
            => Assert.Throws<ArgumentException>(
                () => ShuffleChars(string.Empty, int.MaxValue));

        [Test]
        public void ShuffleChars_IfSourceStringIsWhiteSpaced_ThrowArgumentException()
            => Assert.Throws<ArgumentException>(
                () => ShuffleChars("   ", int.MaxValue));

        [Test]
        public void ShuffleChars_IfSourceStringIsWhiteSpacedWithInvisibleChars_ThrowArgumentException()
            => Assert.Throws<ArgumentException>(
                () => ShuffleChars("  \t\n  \t \r", int.MaxValue));

        [Test]
        public void ShuffleChars_NegativeCounter_ThrowArgumentException()
            => Assert.Throws<ArgumentException>(
                () => ShuffleChars("Das lässt sich nicht ändern.", -1));

        [TestCaseSource(nameof(TestCases))]
        public void ShuffleChars_WithTestCaseData(string source, int count, string expected)
        {
            Assert.AreEqual(expected, ShuffleChars(source, count));
        }
    }
}
