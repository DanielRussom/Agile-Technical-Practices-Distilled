namespace Agile_Technical_Practices_Distilled.Chapter_5.CalisthenicTicTacToe
{
    public class CalisthenicTicTacToeGame
    {
        private GameBoard Board;

        public CalisthenicTicTacToeGame()
        {
            Board = new GameBoard();
        }

        public bool IsBoardEqualTo(List<List<char>> toCompare)
        {
            return Board.Equals(toCompare);
        }
    }
}