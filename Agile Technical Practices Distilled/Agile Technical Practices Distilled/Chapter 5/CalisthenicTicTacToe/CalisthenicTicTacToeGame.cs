namespace Agile_Technical_Practices_Distilled.Chapter_5.CalisthenicTicTacToe
{
    public class CalisthenicTicTacToeGame
    {
        private GameBoard Board;
        private int TurnNumber;

        public CalisthenicTicTacToeGame()
        {
            Board = new GameBoard();
        }

        public bool IsBoardEqualTo(List<List<char>> toCompare)
        {
            return Board.Equals(toCompare);
        }

        public void Play(BoardPosition position)
        {
            position.Player = GetPlayer();

            Board.SetMove(position);

            TurnNumber++;
        }

        private char GetPlayer()
        {
            if (TurnNumber % 2 == 1)
            {
                return 'O';
            }

            return 'X';
        }
    }
}