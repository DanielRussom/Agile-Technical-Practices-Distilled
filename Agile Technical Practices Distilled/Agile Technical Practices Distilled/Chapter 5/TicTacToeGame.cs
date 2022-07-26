namespace Agile_Technical_Practices_Distilled.Chapter_5
{
    public class TicTacToeGame
    {
        private readonly char[,] board;
        private List<char> playerList;
        private int turnNumber;

        public TicTacToeGame()
        {
            board = new char[3, 3];
            playerList = new List<char> { 'X', 'O' };
            turnNumber = 0;
        }

        public char[,] GetBoard()
        {
            return board;
        }

        public string Play(BoardPosition position)
        {
            ValidateMove(position);

            var currentPlayer = GetCurrentPlayer();

            board[position.XCoordinate, position.YCoordinate] = currentPlayer;

            var hasWon = CheckWinConditions(position, currentPlayer);

            if (hasWon)
            {
                return $"Player {currentPlayer} wins!";
            }


            turnNumber++;

            return string.Empty;
        }

        private void ValidateMove(BoardPosition position)
        {
            if (position.XCoordinate < 0 || position.XCoordinate > 2 || position.YCoordinate < 0 || position.YCoordinate > 2)
            {
                throw new InvalidMoveException($"Position {position.XCoordinate},{position.YCoordinate} is not valid.");
            }

            if (board[position.XCoordinate, position.YCoordinate] != default)
            {
                throw new InvalidMoveException($"Position {position.XCoordinate},{position.YCoordinate} has already been played.");
            }
        }

        private char GetCurrentPlayer()
        {
            return playerList[turnNumber % 2];
        }

        private bool CheckWinConditions(BoardPosition position, char currentPlayer)
        {
            var hasVerticalWon = true;
            var hasHorizontalWon = true;

            for (int i = 0; i < 3; i++)
            {
                if (board[position.XCoordinate, i] != currentPlayer)
                {
                    hasVerticalWon = false;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (board[i, position.YCoordinate] != currentPlayer)
                {
                    hasHorizontalWon = false;
                }
            }

            if(board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
            {
                return true;
            }

            if (board[2, 0] == currentPlayer && board[1, 1] == currentPlayer && board[0, 2] == currentPlayer)
            {
                return true;
            }

            return hasVerticalWon || hasHorizontalWon;
        }
    }
}