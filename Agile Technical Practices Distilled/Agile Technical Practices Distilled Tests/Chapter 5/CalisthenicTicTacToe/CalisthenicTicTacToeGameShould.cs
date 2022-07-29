using Agile_Technical_Practices_Distilled.Chapter_5.CalisthenicTicTacToe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_5.CalisthenicTicTacToe
{
    [TestClass]
    public class CalisthenicTicTacToeGameShould
    {
        private List<List<char>> ExpectedBoard;
        private CalisthenicTicTacToeGame UnderTest;

        public CalisthenicTicTacToeGameShould()
        {
            UnderTest = new CalisthenicTicTacToeGame();
            ExpectedBoard = new List<List<char>>
            {
                new List<char>{' ', ' ', ' '},
                new List<char>{' ', ' ', ' '},
                new List<char>{' ', ' ', ' '}
            };
        }

        [TestMethod]
        public void Start_with_an_empty_board()
        {
            var result = UnderTest.IsBoardEqualTo(ExpectedBoard);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 2)]
        [DataRow(2, 2)]
        public void Set_X_at_expected_position(int x, int y)
        {
            ExpectedBoard[x][y] = 'X';

            UnderTest.Play(new BoardPosition { X = x, Y = y });

            var result = UnderTest.IsBoardEqualTo(ExpectedBoard);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Set_O_on_the_second_turn()
        {
            var UnderTest = new CalisthenicTicTacToeGame();
            ExpectedBoard[0][0] = 'X';
            ExpectedBoard[1][1] = 'O';

            UnderTest.Play(new BoardPosition { X = 0, Y = 0 });
            UnderTest.Play(new BoardPosition { X = 1, Y = 1 });

            var result = UnderTest.IsBoardEqualTo(ExpectedBoard);
            Assert.IsTrue(result);
        }
    }
}
