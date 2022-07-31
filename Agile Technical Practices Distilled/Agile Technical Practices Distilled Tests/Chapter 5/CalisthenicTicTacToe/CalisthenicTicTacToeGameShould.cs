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
            AssertExpectedBoardIsCorrect();
        }

        private void AssertExpectedBoardIsCorrect()
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

            var result = UnderTest.Play(new BoardPosition { XPosition = x, YPosition = y });

            Assert.AreEqual(string.Empty, result);
            AssertExpectedBoardIsCorrect();
        }

        [TestMethod]
        [DataRow(1, 1)]
        [DataRow(2, 0)]
        [DataRow(0, 1)]
        public void Set_O_on_the_second_turn(int x, int y)
        {
            ExpectedBoard[0][0] = 'X';
            ExpectedBoard[x][y] = 'O';

            UnderTest.Play(new BoardPosition { XPosition = 0, YPosition = 0 });
            var result = UnderTest.Play(new BoardPosition { XPosition = x, YPosition = y });

            Assert.AreEqual(string.Empty, result);
            AssertExpectedBoardIsCorrect();
        }

        [TestMethod]
        public void Not_allow_the_same_position_to_be_played_twice()
        {
            ExpectedBoard[0][0] = 'X';

            UnderTest.Play(new BoardPosition { XPosition = 0, YPosition = 0 });
            
            Assert.ThrowsException<InvalidMoveException>(() => UnderTest.Play(new BoardPosition { XPosition = 0, YPosition = 0 }));
            Assert.IsTrue(UnderTest.IsBoardEqualTo(ExpectedBoard));
        }

        [TestMethod]
        public void Win_the_game_for_a_horizonal_row_of_Xs()
        {
            UnderTest.Play(new BoardPosition { XPosition = 0, YPosition = 0 });
            UnderTest.Play(new BoardPosition { XPosition = 1, YPosition = 1 });
            UnderTest.Play(new BoardPosition { XPosition = 0, YPosition = 1 });
            UnderTest.Play(new BoardPosition { XPosition = 2, YPosition = 2 });
            var result = UnderTest.Play(new BoardPosition { XPosition = 0, YPosition = 2 });
            Assert.AreEqual("Player X wins!", result);
        }
    }
}
