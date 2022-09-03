namespace Agile_Technical_Practices_Distilled.Chapter_5.GameOfLife
{
    public class LifeBoard
    {
        private readonly ILifeBoardDisplayer displayer;
        private bool[,] gameBoard;

        public LifeBoard(ILifeBoardDisplayer displayer)
        {
            this.displayer = displayer;
            gameBoard = new bool[3, 3];
        }

        public void DisplayBoard()
        {
            displayer.DisplayBoard(gameBoard);
        }

        public void ToggleCell(Position cellPosition)
        {
            var newCellValue = !gameBoard[cellPosition.xPosition, cellPosition.yPosition];
            gameBoard[cellPosition.xPosition, cellPosition.yPosition] = newCellValue;
        }

        public void TakeTurn()
        {
            var updatedGameBoard = new bool[3, 3];

            for(int i = 0; i < 3; i++)
            {
                if (gameBoard[0, i] && gameBoard[1, i] && gameBoard[2, i])
                {
                    updatedGameBoard[1, i] = true;
                }
            }
            if (gameBoard[1, 0] && gameBoard[1, 1] && gameBoard[1, 2])
            {
                updatedGameBoard[1, 1] = true;
            }

            gameBoard = updatedGameBoard;
        }
    }
}