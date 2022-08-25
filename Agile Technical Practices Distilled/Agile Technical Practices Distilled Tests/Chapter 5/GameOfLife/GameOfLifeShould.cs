using Agile_Technical_Practices_Distilled.Chapter_5.GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_5.GameOfLife
{
    [TestClass]
    public class GameOfLifeShould
    {
        [TestMethod]
        public void Set_cells_as_dead_by_default()
        {
            var UnderTest = new LifeBoard();

            var input = new Coordinates();

            CellState cellState = UnderTest.GetCellState(input);

            Assert.AreEqual(CellState.DEAD, cellState);
        }
    }
}
