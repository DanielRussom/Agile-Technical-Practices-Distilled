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
        public void Set_position_1_1_to_alive()
        {
            var expected = new int[,]{
                { 0, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 0 }
            };


            UnderTest.ToggleCell(1, 1);
            UnderTest.DisplayBoard();

            CollectionAssert.AreEqual(expected, DisplayResult);
        }

        [TestMethod]
        public void Set_position_0_1_to_alive()
        {
            var expected = new int[,]{
                { 0, 0, 0 },
                { 1, 0, 0 },
                { 0, 0, 0 }
            };

            UnderTest.ToggleCell(1, 0);
            UnderTest.DisplayBoard();

            CollectionAssert.AreEqual(expected, DisplayResult);
        }
    }
}
