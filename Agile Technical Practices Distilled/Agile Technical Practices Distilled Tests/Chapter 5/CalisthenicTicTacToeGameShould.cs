﻿using Agile_Technical_Practices_Distilled.Chapter_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_5
{
    [TestClass]
    public class CalisthenicTicTacToeGameShould
    {
        [TestMethod]
        public void Start_with_an_empty_board()
        {
            var UnderTest = new CalisthenicTicTacToeGame();
            var expectedBoard = new List<List<char>>();

            var result = UnderTest.GetBoard();
            CollectionAssert.AreEqual(expectedBoard, result);
        }
    }
}
