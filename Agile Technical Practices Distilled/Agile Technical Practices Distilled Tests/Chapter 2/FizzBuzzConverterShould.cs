using Agile_Technical_Practices_Distilled.Chapter_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_2
{
    [TestClass]
    public class FizzBuzzConverterShould
    {
        private FizzBuzzConverter UnderTest;

        public FizzBuzzConverterShould()
        {
            UnderTest = new FizzBuzzConverter();
        }


        [TestMethod]
        [DataRow (1)]
        [DataRow (2)]
        [DataRow (4)]
        [DataRow (7)]
        public void Return_string_value_of_input(int input)
        {
            var result = UnderTest.Convert(input);

            Assert.AreEqual(result, input.ToString());
        }

        [TestMethod]
        [DataRow (3)]
        [DataRow (6)]
        [DataRow (9)]
        [DataRow (12)]
        public void Return_fizz(int input)
        {
            var result = UnderTest.Convert(input);

            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(20)]
        [DataRow(25)]
        public void Return_buzz(int input)
        {
            var result = UnderTest.Convert(input);

            Assert.AreEqual(result, "Buzz");
        }
    }
}
