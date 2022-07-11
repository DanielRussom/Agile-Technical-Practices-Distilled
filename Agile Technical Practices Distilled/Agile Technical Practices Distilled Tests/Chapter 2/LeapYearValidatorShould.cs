using Agile_Technical_Practices_Distilled.Chapter_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_2
{
    [TestClass]
    public class LeapYearValidatorShould
    {
        [TestMethod]
        public void Return_false()
        {
            var UnderTest = new LeapYearValidator();

            var result = UnderTest.Validate(2001);
            Assert.IsFalse(result);
        }
    }
}
