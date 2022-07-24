﻿using Agile_Technical_Practices_Distilled.Chapter_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_5
{
    [TestClass]
    public class TicTacToeGameShould
    {
        TicTacToeGame UnderTest;
        char[,] ExpectedBoard;

        public TicTacToeGameShould()
        {
            UnderTest = new TicTacToeGame();

            ExpectedBoard = new char[3, 3];
        }

        private void AssertActualMatchesExpectedBoard()
        {
            var result = UnderTest.GetBoard();
            CollectionAssert.AreEqual(ExpectedBoard, result);
        }

        [TestMethod]
        public void Start_with_an_empty_board()
        {
            AssertActualMatchesExpectedBoard();
        }

        [TestMethod]
        [DataRow (1, 1)]
        [DataRow (2, 0)]
        [DataRow (0, 0)]
        public void Mark_the_correct_position_with_X(int xCoord, int yCoord)
        {
            ExpectedBoard[xCoord, yCoord] = 'X';

            UnderTest.Play(xCoord, yCoord);

            AssertActualMatchesExpectedBoard();
        }

        [TestMethod]
        [DataRow(0, 1)]
        [DataRow(2, 0)]
        public void Mark_the_board_with_O_the_second_turn(int xCoord, int yCoord)
        {
            ExpectedBoard[0, 0] = 'X';
            ExpectedBoard[xCoord, yCoord] = 'O';

            UnderTest.Play(0, 0);
            UnderTest.Play(xCoord, yCoord);

            AssertActualMatchesExpectedBoard();
        }

        [TestMethod]
        public void Iterate_between_X_and_O_for_each_turn()
        {
            ExpectedBoard[0, 0] = 'X';
            ExpectedBoard[0, 1] = 'O';
            ExpectedBoard[1, 0] = 'X';
            ExpectedBoard[1, 1] = 'O';

            UnderTest.Play(0, 0);
            UnderTest.Play(0, 1);
            UnderTest.Play(1, 0);
            UnderTest.Play(1, 1);

            AssertActualMatchesExpectedBoard();
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 2)]
        public void Not_allow_the_same_position_to_be_played_twice(int xCoord, int yCoord)
        {
            ExpectedBoard[xCoord, yCoord] = 'X';

            UnderTest.Play(xCoord, yCoord);

            Assert.ThrowsException<InvalidMoveException>(() => UnderTest.Play(xCoord, yCoord));
            AssertActualMatchesExpectedBoard();
        }

        [TestMethod]
        public void Not_allow_3_3_to_be_played()
        {
            Assert.ThrowsException<InvalidMoveException>(() => UnderTest.Play(3, 3));
            AssertActualMatchesExpectedBoard();
        }
    }
}
