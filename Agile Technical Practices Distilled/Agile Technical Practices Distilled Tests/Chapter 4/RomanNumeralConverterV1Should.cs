using Agile_Technical_Practices_Distilled.Chapter_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_4
{
    [TestClass]
    public class RomanNumeralConverterV1Should
    {
        [TestMethod]
        [DataRow (1, "I")]
        [DataRow (2, "II")]
        [DataRow (3, "III")]
        [DataRow (4, "IV")]
        [DataRow (5, "V")]
        [DataRow (6, "VI")]
        [DataRow (9, "IX")]
        [DataRow (10, "X")]
        [DataRow (17, "XVII")]
        [DataRow (36, "XXXVI")]

        public void Convert_integer_to_expected_roman_numeral(int input, string expected)
        {
            var UnderTest = new RomanNumeralConverterV1();

            var result = UnderTest.Convert(input);

            Assert.AreEqual(expected, result);
        }
    }
}
