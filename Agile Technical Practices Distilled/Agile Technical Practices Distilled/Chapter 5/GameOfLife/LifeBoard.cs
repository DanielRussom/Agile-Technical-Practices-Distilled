﻿namespace Agile_Technical_Practices_Distilled.Chapter_5.GameOfLife
{
    public class LifeBoard
    {
        private readonly ILifeBoardDisplayer displayer;
        private readonly bool[,] gameBoard;

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
            var newCellValue = !gameBoard[cellPosition.xCoordinate, cellPosition.yCoordinate];
            gameBoard[cellPosition.xCoordinate, cellPosition.yCoordinate] = newCellValue;
        }
    }
}