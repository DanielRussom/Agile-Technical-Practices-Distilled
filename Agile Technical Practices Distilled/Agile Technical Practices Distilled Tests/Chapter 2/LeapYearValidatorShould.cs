using Agile_Technical_Practices_Distilled.Chapter_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_2
{
    [TestClass]
    public class LeapYearValidatorShould
    {
        public LeapYearValidator UnderTest { get; }
        
        public LeapYearValidatorShould()
        {
            UnderTest = new LeapYearValidator();
        }

        [TestMethod]
        [DataRow(2001, false)]
        [DataRow(2003, false)]
        [DataRow(2004, true)]
        [DataRow(2008, true)]
        [DataRow(2012, true)]
        [DataRow(1900, false)]
        [DataRow(2100, false)]
        [DataRow(2300, false)]
        [DataRow(2000, true)]
        [DataRow(2400, true)]

        public void Validate_year(int input, bool expected)
        {
            var result = UnderTest.Validate(input);
            Assert.AreEqual(result, expected);
        }
    }
}
