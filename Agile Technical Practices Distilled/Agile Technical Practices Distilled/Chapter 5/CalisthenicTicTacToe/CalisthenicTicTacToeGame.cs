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

        public string Play(BoardPosition position)
        {
            position.Player = GetPlayer();

            Board.SetMove(position);

            TurnNumber++;

            if (Board.CheckWinState(position))
            {
                return $"Player {position.Player} wins!";
            }

            return string.Empty;
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