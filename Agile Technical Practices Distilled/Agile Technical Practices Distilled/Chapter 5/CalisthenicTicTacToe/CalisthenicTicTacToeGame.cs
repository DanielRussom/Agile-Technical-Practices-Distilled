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

        public GameResult Play(BoardPosition position)
        {
            var returnMessage = string.Empty;

            position.Player = GetPlayer();

            Board.SetMove(position);

            TurnNumber++;

            if (Board.CheckWinState())
            {
                returnMessage = $"Player {position.Player} wins!";
            }

            return new GameResult(returnMessage);
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