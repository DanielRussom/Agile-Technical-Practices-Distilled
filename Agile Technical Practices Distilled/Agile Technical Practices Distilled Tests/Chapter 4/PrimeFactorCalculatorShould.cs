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
        [DataRow (1)]
        [DataRow (2)]
        [DataRow (3)]
        [DataRow (5)]
        public void Convert_prime_numbers_to_a_list(int input)
        {
            var result = UnderTest.Calculate(input);

            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(result.Contains(input));
        }
    }
}
