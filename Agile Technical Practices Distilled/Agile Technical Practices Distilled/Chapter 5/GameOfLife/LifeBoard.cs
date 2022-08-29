namespace Agile_Technical_Practices_Distilled.Chapter_5.GameOfLife
{
    public class LifeBoard
    {
        private readonly ILifeBoardDisplayer displayer;
        private int[,] gameBoard;

        public LifeBoard(ILifeBoardDisplayer displayer)
        {
            this.displayer = displayer;
            gameBoard = new int[3, 3];
        }

        public void DisplayBoard()
        {
            displayer.DisplayBoard(gameBoard);
        }

        public void ToggleCell(Position cellPosition)
        {
            gameBoard[cellPosition.xCoordinate, cellPosition.yCoordinate] = 1;
        }
    }
}