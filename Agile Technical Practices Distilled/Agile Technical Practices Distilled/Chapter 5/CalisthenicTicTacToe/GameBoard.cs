namespace Agile_Technical_Practices_Distilled.Chapter_5.CalisthenicTicTacToe
{
    public class GameBoard
    {
        private List<List<char>> BoardPositions;
        private int TurnNumber;

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
            var nextPlayer = 'X';

            if(TurnNumber % 2 == 1)
            {
                nextPlayer = 'O';
            }

            BoardPositions[position.X][position.Y] = nextPlayer;

            TurnNumber++;
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