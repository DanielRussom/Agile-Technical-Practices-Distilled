using Agile_Technical_Practices_Distilled.Chapter_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
        [DataRow (2)]
        [DataRow (3)]
        [DataRow (5)]
        [DataRow (7)]
        public void Convert_prime_numbers_to_a_list(int input)
        {
            var expected = new List<int> { input };
            var result = UnderTest.Calculate(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Convert_4_to_a_list_of_two_2s()
        {
            var expected = new List<int> { 2, 2 };
            var result = UnderTest.Calculate(4);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Convert_6_to_a_list_of_2_and_3()
        {
            var expected = new List<int> { 2, 3 };
            var result = UnderTest.Calculate(6);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Convert_8_to_a_list_of_three_2s()
        {
            var expected = new List<int> { 2, 2, 2 };
            var result = UnderTest.Calculate(8);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Convert_9_to_a_list_of_three_3s()
        {
            var expected = new List<int> { 3, 3 };
            var result = UnderTest.Calculate(9);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
