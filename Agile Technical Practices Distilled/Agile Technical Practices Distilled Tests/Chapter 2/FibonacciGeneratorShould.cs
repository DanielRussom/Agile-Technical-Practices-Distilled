using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Agile_Technical_Practices_Distilled.Tests.Chapter_2
{
    [TestClass]
    public class FibonacciGeneratorShould
    {
        [TestMethod]
        public void Generate_0()
        {
            var UnderTest = new FibonacciGenerator();

            var result = UnderTest.Generate(1);

            Assert.AreEqual(0, result);
        }
    }
}
