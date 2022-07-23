using Agile_Technical_Practices_Distilled.Chapter_5;
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
    }
}
