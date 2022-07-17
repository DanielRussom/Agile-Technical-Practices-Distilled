﻿using Agile_Technical_Practices_Distilled.Chapter_4;
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
        public void Convert_1_to_I(int input, string expected)
        {
            var UnderTest = new RomanNumeralConverterV1();

            var result = UnderTest.Convert(input);

            Assert.AreEqual(expected, result);
        }
    }
}
