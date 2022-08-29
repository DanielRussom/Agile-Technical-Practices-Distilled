using Agile_Technical_Practices_Distilled.Chapter_5.GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_5.GameOfLife
{
    [TestClass]
    public class GameOfLifeShould
    {
        LifeBoard UnderTest;
        bool[,]? DisplayResult;

        public GameOfLifeShould()
        {
            var displayer = new Mock<ILifeBoardDisplayer>();
            displayer.Setup(x => x.DisplayBoard(It.IsAny<bool[,]>())).Callback<bool[,]>(r => DisplayResult = r);
            UnderTest = new LifeBoard(displayer.Object);
        }

        [TestMethod]
        public void Display_starting_board()
        {
            var expected = new bool[3,3];

            UnderTest.DisplayBoard();

            CollectionAssert.AreEqual(expected, DisplayResult);
        }

        [TestMethod]
        [DataRow (1,1, DisplayName = "1,1")]
        [DataRow (0,1, DisplayName = "0,1")]
        [DataRow (2,2, DisplayName = "2,2")]
        public void Set_position_to_alive(int xCoord, int yCoord)
        {
            var expected = new bool[3, 3];
            expected[xCoord, yCoord] = true;
            var position = new Position { xPosition = xCoord, yPosition = yCoord };
            
            UnderTest.ToggleCell(position);
            UnderTest.DisplayBoard();

            CollectionAssert.AreEqual(expected, DisplayResult);
        }

        [TestMethod]
        public void Set_multiple_positions_to_alive()
        {
            var expected = new bool[3, 3];
            expected[0, 0] = true;
            expected[0, 1] = true;
            expected[2, 2] = true;

            UnderTest.ToggleCell(new Position { xPosition = 0, yPosition = 0 });
            UnderTest.ToggleCell(new Position { xPosition = 0, yPosition = 1 });
            UnderTest.ToggleCell(new Position { xPosition = 2, yPosition = 2 });
            UnderTest.DisplayBoard();

            CollectionAssert.AreEqual(expected, DisplayResult);
        }

        [TestMethod]
        public void Set_alive_cell_to_dead()
        {
            var expected = new bool[3, 3];

            var position = new Position { xPosition = 0, yPosition = 0 };

            UnderTest.ToggleCell(position);
            UnderTest.ToggleCell(position);
            UnderTest.DisplayBoard();

            CollectionAssert.AreEqual(expected, DisplayResult);

        }
    }
}
