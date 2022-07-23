using Agile_Technical_Practices_Distilled.Chapter_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_5
{
    [TestClass]
    public class TicTacToeGameShould
    {
        [TestMethod]
        public void Start_with_an_empty_board()
        {
            var UnderTest = new TicTacToeGame();

            var expected = new char[3,3];

            var result = UnderTest.GetBoard();

            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}
