﻿using Agile_Technical_Practices_Distilled.Chapter_2;
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
        [DataRow(2001)]
        [DataRow(2003)]

        public void Return_false_for_non_multiples_of_4(int input)
        {
            var result = UnderTest.Validate(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow (2004)]
        [DataRow (2008)]
        [DataRow (2012)]
        public void Return_true_for_multiples_of_4(int input)
        {
            var result = UnderTest.Validate(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(1900)]
        [DataRow(2100)]
        [DataRow(2300)]
        public void Return_false_for_multiples_of_100_and_not_400(int input)
        {
            var result = UnderTest.Validate(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_true_for_multiples_of_400()
        {
            var result = UnderTest.Validate(2000);
            Assert.IsTrue(result);
        }
    }
}
