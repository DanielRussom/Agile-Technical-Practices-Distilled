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
            var expected = new int[5, 5]{
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }
            };

            var underTest = new LifeBoard();
            Assert.IsTrue(underTest.Equals(expected));
        }
    }
}
