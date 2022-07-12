using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Agile_Technical_Practices_Distilled.Tests.Chapter_2
{
    [TestClass]
    public class FibonacciGeneratorShould
    {
        [TestMethod]
        [DataRow (1, 0)]
        [DataRow (2, 1)]
        [DataRow (3, 1)]
        [DataRow (4, 2)]
        public void Generate_nth_fibonacci_number(int input, int expected)
        {
            var UnderTest = new FibonacciGenerator();

            var result = UnderTest.Generate(input);

            Assert.AreEqual(expected, result);
        }
    }
}
