﻿using Agile_Technical_Practices_Distilled.Chapter_5.CalisthenicTicTacToe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_5.CalisthenicTicTacToe
{
    [TestClass]
    public class CalisthenicTicTacToeGameShould
    {
        [TestMethod]
        public void Start_with_an_empty_board()
        {
            var UnderTest = new CalisthenicTicTacToeGame();
            var expectedBoard = new List<List<char>>
            {
                new List<char>{' ', ' ', ' '},
                new List<char>{' ', ' ', ' '},
                new List<char>{' ', ' ', ' '}
            };

            var result = UnderTest.IsBoardEqualTo(expectedBoard);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Set_X_at_position_0_0()
        {
            var UnderTest = new CalisthenicTicTacToeGame();
            var expectedBoard = new List<List<char>>
            {
                new List<char>{'X', ' ', ' '},
                new List<char>{' ', ' ', ' '},
                new List<char>{' ', ' ', ' '}
            };

            UnderTest.Play(0, 0);

            var result = UnderTest.IsBoardEqualTo(expectedBoard);
            Assert.IsTrue(result);
        }
    }
}
