namespace Agile_Technical_Practices_Distilled.Chapter_5.CalisthenicTicTacToe
{
    public class GameBoard
    {
        private List<List<char>> BoardPositions;

        private BoardPosition LastMove = new();

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

            LastMove = position;

            BoardPositions[LastMove.XPosition][LastMove.YPosition] = LastMove.Player;
        }

        internal bool CheckWinState()
        {
            if (RowMatchesPlayer(BoardPositions[LastMove.XPosition]))
            {
                return true;
            }

            if (CheckYAxisMatches())
            {
                return true;
            }

            var isDiagonalMatched = CheckDiagonalMatches();

            return isDiagonalMatched;
        }

        private bool RowMatchesPlayer(List<char> row)
        {
            return row.All(x => x == LastMove.Player);
        }

        private bool CheckYAxisMatches()
        {
            var yCoord = LastMove.YPosition;
            var verticalRow = new List<char> { 
                BoardPositions[0][yCoord], 
                BoardPositions[1][yCoord], 
                BoardPositions[2][yCoord] 
            };

            return RowMatchesPlayer(verticalRow);
        }

        private bool CheckDiagonalMatches()
        {
            var diagonalDown = new List<char> {
                BoardPositions[0][0],
                BoardPositions[1][1],
                BoardPositions[2][2]
            };

            var diagonalUp = new List<char> {
                BoardPositions[2][0],
                BoardPositions[1][1],
                BoardPositions[0][2]
            };

            return RowMatchesPlayer(diagonalDown) || RowMatchesPlayer(diagonalUp);
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