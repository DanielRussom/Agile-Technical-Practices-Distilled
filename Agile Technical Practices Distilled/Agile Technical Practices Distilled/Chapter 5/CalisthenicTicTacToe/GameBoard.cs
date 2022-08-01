namespace Agile_Technical_Practices_Distilled.Chapter_5.CalisthenicTicTacToe
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

            if (CheckRowMatches(position))
            {
                return true;
            }

            var isDiagonalMatched = CheckDiagonalMatches(position);

            return isDiagonalMatched;
        }

        private bool CheckRowMatches(BoardPosition position)
        {
            var yCoord = position.YPosition;
            var verticalRow = new List<char> { 
                BoardPositions[0][yCoord], 
                BoardPositions[1][yCoord], 
                BoardPositions[2][yCoord] 
            };

            return verticalRow.All(x => x == position.Player);
        }

        private bool CheckDiagonalMatches(BoardPosition position)
        {
            var diagonal = new List<char> {
                BoardPositions[0][0],
                BoardPositions[1][1],
                BoardPositions[2][2]
            };

            return diagonal.All(x => x == position.Player);

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