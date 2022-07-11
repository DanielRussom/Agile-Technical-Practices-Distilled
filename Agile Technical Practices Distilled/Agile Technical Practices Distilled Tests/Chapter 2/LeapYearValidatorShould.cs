using Agile_Technical_Practices_Distilled.Chapter_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_2
{
    [TestClass]
    public class LeapYearValidatorShould
    {

        [TestMethod]
        public void Return_false_for_2001()
        {
            var UnderTest = new LeapYearValidator();

            var result = UnderTest.Validate(2001);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_true_for_2004()
        {
            var UnderTest = new LeapYearValidator();

            var result = UnderTest.Validate(2004);
            Assert.IsTrue(result);
        }
    }
}
