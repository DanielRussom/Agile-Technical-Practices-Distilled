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

        [TestMethod]
        public void Start_with_an_empty_board()
        {
            var result = UnderTest.GetBoard();

            CollectionAssert.AreEquivalent(ExpectedBoard, result);
        }

        [TestMethod]
        public void Mark_the_middle_position_with_X()
        {
            ExpectedBoard[1, 1] = 'X';

            UnderTest.Play(1, 1);

            var result = UnderTest.GetBoard();
            CollectionAssert.AreEquivalent(ExpectedBoard, result);
        }
    }
}
