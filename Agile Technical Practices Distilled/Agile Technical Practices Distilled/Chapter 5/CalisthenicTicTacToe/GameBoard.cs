﻿namespace Agile_Technical_Practices_Distilled.Chapter_5.CalisthenicTicTacToe
{
    public class GameBoard
    {
        private List<List<char>> BoardPositions;

        public GameBoard()
        {
            BoardPositions = new List<List<char>>
            {   
                new List<char> { ' ', ' ', ' ' },
                new List<char> { ' ', ' ', ' ' },
                new List<char> { ' ', ' ', ' ' }
            };
        }

        internal void SetMove(BoardPosition position)
        {
            if(BoardPositions[position.XPosition][position.YPosition] != ' ')
            {
                throw new InvalidMoveException($"Position {position.XPosition},{position.YPosition} has already been played.");
            }

            BoardPositions[position.XPosition][position.YPosition] = position.Player;
        }

        internal bool CheckWinState(BoardPosition position)
        {
            if (BoardPositions[position.XPosition].All(x => x == position.Player))
            {
                return true;
            }

            if(BoardPositions[0][position.YPosition] == position.Player && BoardPositions[1][position.YPosition] == position.Player && BoardPositions[2][position.YPosition] == position.Player)
            {
                return true;
            }

            return false;
        }

        public bool Equals(List<List<char>> toCompare)
        {
            if (BoardPositions.Count != toCompare.Count)
            {
                return false;
            }

            return GetEqualityOfRows(toCompare);
        }

        private bool GetEqualityOfRows(List<List<char>> toCompare)
        {
            var rowEquality = new List<bool>();

            for (int row = 0; row < BoardPositions.Count; row++)
            {
                var areRowsEqual = BoardPositions[row].SequenceEqual(toCompare[row]);
                rowEquality.Add(areRowsEqual);
            }

            return rowEquality.All(x => x == true);
        }
    }
}