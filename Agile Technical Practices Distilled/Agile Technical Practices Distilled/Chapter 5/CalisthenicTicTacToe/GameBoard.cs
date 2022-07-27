namespace Agile_Technical_Practices_Distilled.Chapter_5.CalisthenicTicTacToe
{
    public class GameBoard
    {
        private List<List<char>> BoardPositions;

        public GameBoard()
        {
            BoardPositions = new List<List<char>>
            {
                new List<char>(),
                new List<char>(),
                new List<char>()
            };
        }


        public bool Equals(List<List<char>> toCompare)
        {
            if (BoardPositions.Count != toCompare.Count)
            {
                return false;
            }


            for (int row = 0; row < BoardPositions.Count; row++)
            {
                if (!BoardPositions[row].SequenceEqual(toCompare[row])){
                    return false;
                }
            }

            return true;
        }
    }
}