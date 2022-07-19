using Agile_Technical_Practices_Distilled.Chapter_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_4
{
    [TestClass]
    public class PrimeFactorCalculatorShould
    {
        private readonly PrimeFactorCalculator UnderTest;

        public PrimeFactorCalculatorShould()
        {
            UnderTest = new PrimeFactorCalculator();
        }

        [TestMethod]
        public void Convert_1_to_a_list_with_1()
        {
            var result = UnderTest.Calculate(1);

            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(result.Contains(1));
        }

        [TestMethod]
        public void Convert_2_to_a_list_with_2()
        {
            var result = UnderTest.Calculate(2);

            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(result.Contains(2));
        }
    }
}
