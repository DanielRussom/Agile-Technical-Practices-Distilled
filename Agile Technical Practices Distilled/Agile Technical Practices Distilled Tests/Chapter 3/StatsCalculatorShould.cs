﻿using Agile_Technical_Practices_Distilled.Chapter_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_3
{
    [TestClass]
    public class StatsCalculatorShould
    {
        private readonly StatsCalculator UnderTest;

        public StatsCalculatorShould()
        {
            UnderTest = new StatsCalculator();
        }

        [TestMethod]
        public void Set_minimum_value_to_0()
        {
            var input = new List<int> { 0, 1 };

            var result = UnderTest.Calculate(input);

            Assert.AreEqual(0, result.MinimumValue);
        }

        [TestMethod]
        public void Set_minimum_value_to_1()
        {
            var input = new List<int> { 1 };

            var result = UnderTest.Calculate(input);

            Assert.AreEqual(1, result.MinimumValue);
        }

        [TestMethod]
        public void Set_minimum_value_to_negative_1()
        {
            var input = new List<int> { -1, 0, 10 };

            var result = UnderTest.Calculate(input);

            Assert.AreEqual(-1, result.MinimumValue);
        }

        [TestMethod]
        public void Set_maximum_value_to_1()
        {
            var input = new List<int> { 1 };

            var result = UnderTest.Calculate(input);

            Assert.AreEqual(1, result.MaximumValue);
        }

        [TestMethod]
        public void Set_maximum_value_to_5()
        {
            var input = new List<int> { 1, 5 };

            var result = UnderTest.Calculate(input);

            Assert.AreEqual(5, result.MaximumValue);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(5)]
        public void Set_element_count_to_number_of_elements(int elementCount)
        {
            var input = new List<int>();
            for(int i = 0; i < elementCount; i++)
            {
                input.Add(i);
            }

            var result = UnderTest.Calculate(input);

            Assert.AreEqual(elementCount, result.ElementCount);
        }

        [TestMethod]
        public void Set_average_value_to_1()
        {
            var input = new List<int> { 1 };

            var result = UnderTest.Calculate(input);

            Assert.AreEqual(1, result.AverageValue);
        }
    }
}
