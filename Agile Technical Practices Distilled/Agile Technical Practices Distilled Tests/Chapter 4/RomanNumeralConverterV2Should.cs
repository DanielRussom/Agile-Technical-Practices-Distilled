using Agile_Technical_Practices_Distilled.Chapter_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_4
{
    [TestClass]
    public class RomanNumeralConverterV2Should
    {
        [TestMethod]
        [DataRow(1, "I")]
        [DataRow(2, "II")]
        [DataRow(3, "III")]
        [DataRow(4, "IV")]
        public void Convert_arabic_number_into_expected_roman_numeral(int input, string expected)
        {
            var UnderTest = new RomanNumeralConverterV2();

            var result = UnderTest.Convert(input);

            Assert.AreEqual(expected, result);
        }
    }
}
