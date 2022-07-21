using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Agile_Technical_Practices_Distilled.Tests.Chapter_4
{
    [TestClass]
    public class BooleanCalculatorShould
    {
        [TestMethod]
        [DataRow("TRUE", true)]
        [DataRow("FALSE", false)]
        [DataRow("NOT TRUE", false)]
        [DataRow("NOT FALSE", true)]
        [DataRow("TRUE AND TRUE", true)]
        [DataRow("TRUE AND FALSE", false)]
        [DataRow("FALSE AND TRUE", false)]
        [DataRow("FALSE AND FALSE", false)]
        [DataRow("TRUE AND NOT TRUE", false)]
        [DataRow("TRUE AND NOT FALSE", true)]
        [DataRow("FALSE AND NOT FALSE", false)]
        [DataRow("NOT FALSE AND TRUE", true)]
        [DataRow("NOT FALSE AND NOT FALSE", true)]
        [DataRow("TRUE OR FALSE", true)]
        [DataRow("FALSE OR FALSE", false)]
        [DataRow("FALSE OR NOT FALSE", true)]
        [DataRow("TRUE OR TRUE AND TRUE", true)]
        [DataRow("TRUE AND TRUE AND FALSE", false)]
        [DataRow("TRUE AND FALSE OR TRUE", true)]
        [DataRow("FALSE OR FALSE OR TRUE", true)]
        public void Calculate_expected_result(string input, bool expected)
        {
            var UnderTest = new BooleanCalculator();

            var result = UnderTest.Calculate(input);

            Assert.AreEqual(expected, result);
        }
    }
}
