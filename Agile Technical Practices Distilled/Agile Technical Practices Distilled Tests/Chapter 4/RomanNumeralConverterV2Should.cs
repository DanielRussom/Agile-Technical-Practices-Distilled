using Agile_Technical_Practices_Distilled.Chapter_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_4
{
    [TestClass]
    public class RomanNumeralConverterV2Should
    {
        [TestMethod]
        public void Convert_1_into_I()
        {
            var UnderTest = new RomanNumeralConverterV2();

            var result = UnderTest.Convert(1);

            Assert.AreEqual("I", result);
        }
    }
}
