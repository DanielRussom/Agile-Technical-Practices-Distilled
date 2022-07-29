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
            BoardPositions[position.X][position.Y] = position.Player;
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