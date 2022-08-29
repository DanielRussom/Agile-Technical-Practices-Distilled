using Agile_Technical_Practices_Distilled.Chapter_5.GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_5.GameOfLife
{
    [TestClass]
    public class GameOfLifeShould
    {
        LifeBoard UnderTest;
        int[,]? DisplayResult;

        public GameOfLifeShould()
        {
            var displayer = new Mock<ILifeBoardDisplayer>();
            displayer.Setup(x => x.DisplayBoard(It.IsAny<int[,]>())).Callback<int[,]>(r => DisplayResult = r);
            UnderTest = new LifeBoard(displayer.Object);
        }

        [TestMethod]
        public void Display_starting_board()
        {
            var expected = new int[,]{
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            UnderTest.DisplayBoard();

            CollectionAssert.AreEqual(expected, DisplayResult);
        }

        [TestMethod]
        [DataRow (1,1, DisplayName = "1,1")]
        [DataRow (0,1, DisplayName = "0,1")]
        [DataRow (2,2, DisplayName = "2,2")]
        public void Set_position_to_alive(int xCoord, int yCoord)
        {
            var expected = new int[3, 3];
            expected[xCoord, yCoord] = 1;

            UnderTest.ToggleCell(xCoord, yCoord);
            UnderTest.DisplayBoard();

            CollectionAssert.AreEqual(expected, DisplayResult);
        }
    }
}
