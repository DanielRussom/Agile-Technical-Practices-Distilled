using Agile_Technical_Practices_Distilled.Chapter_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_3
{
    [TestClass]
    public class StatsCalculatorShould
    {
        [TestMethod]
        public void Set_minimum_value_to_0()
        {
            var UnderTest = new StatsCalculator();
            var input = new List<int> { 0 };

            var result = UnderTest.Calculate(input);

            Assert.AreEqual(0, result.MinimumValue);
        }

        [TestMethod]
        public void Set_minimum_value_to_1()
        {
            var UnderTest = new StatsCalculator();
            var input = new List<int> { 1 };

            var result = UnderTest.Calculate(input);

            Assert.AreEqual(1, result.MinimumValue);
        }
    }
}
