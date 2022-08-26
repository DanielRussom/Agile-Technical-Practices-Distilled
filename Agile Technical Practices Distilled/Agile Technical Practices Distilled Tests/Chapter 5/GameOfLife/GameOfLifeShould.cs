﻿using Agile_Technical_Practices_Distilled.Chapter_5.GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_5.GameOfLife
{
    [TestClass]
    public class GameOfLifeShould
    {
        [TestMethod]
        public void Start_with_only_dead_cells()
        {
            var expected = new int[,]{
                { 0, 0 },
                { 0, 0 }
            };
            var underTest = new LifeBoard();

            Assert.IsTrue(underTest.Equals(expected));
        }

        [TestMethod]
        public void Detect_when_0_0_positions_are_not_equal()
        {
            var expected = new int[2, 2]{
                { 1, 0 },
                { 0, 0 },
            };
            var underTest = new LifeBoard();

            Assert.IsFalse(underTest.Equals(expected));
        }
    }
}
