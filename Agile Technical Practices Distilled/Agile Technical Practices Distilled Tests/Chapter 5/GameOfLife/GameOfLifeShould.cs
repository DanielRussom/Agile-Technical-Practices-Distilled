using Agile_Technical_Practices_Distilled.Chapter_5.GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_5.GameOfLife
{
    [TestClass]
    public class GameOfLifeShould
    {
        [TestMethod]
        public void Display_starting_board()
        {
            var expected = new int[,]{
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };
            int[,]? result = null;
            var displayer = new Mock<ILifeBoardDisplayer>();
            displayer.Setup(x => x.DisplayBoard(It.IsAny<int[,]>())).Callback<int[,]>(r => result = r);
            var underTest = new LifeBoard(displayer.Object);

            underTest.DisplayBoard();

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Set_position_1_1_to_alive()
        {
            var expected = new int[,]{
                { 0, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 0 }
            };
            int[,]? result = null;
            var displayer = new Mock<ILifeBoardDisplayer>();
            displayer.Setup(x => x.DisplayBoard(It.IsAny<int[,]>())).Callback<int[,]>(r => result = r);
            var underTest = new LifeBoard(displayer.Object);

            underTest.ToggleCell(1, 1);
            underTest.DisplayBoard();

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Set_position_0_1_to_alive()
        {
            var expected = new int[,]{
                { 0, 0, 0 },
                { 1, 0, 0 },
                { 0, 0, 0 }
            };
            int[,]? result = null;
            var displayer = new Mock<ILifeBoardDisplayer>();
            displayer.Setup(x => x.DisplayBoard(It.IsAny<int[,]>())).Callback<int[,]>(r => result = r);
            var underTest = new LifeBoard(displayer.Object);

            underTest.ToggleCell(1, 0);
            underTest.DisplayBoard();

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
