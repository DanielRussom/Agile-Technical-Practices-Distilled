namespace Agile_Technical_Practices_Distilled.Chapter_5
{
    public class TicTacToeGame
    {
        private readonly char[,] board;
        private List<char> playerList;
        private int turnNumber;

        private const int BOARD_SIZE = 3;

        public TicTacToeGame()
        {
            board = new char[BOARD_SIZE, BOARD_SIZE];
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

            if(turnNumber >= BOARD_SIZE * BOARD_SIZE)
            {
                return $"It's a draw!";
            }

            return string.Empty;
        }

        private void ValidateMove(BoardPosition position)
        {
            if (CoordinateOutOfRange(position.XCoordinate) || CoordinateOutOfRange(position.YCoordinate))
            {
                throw new InvalidMoveException($"Position {position.XCoordinate},{position.YCoordinate} is not valid.");
            }

            if (board[position.XCoordinate, position.YCoordinate] != default)
            {
                throw new InvalidMoveException($"Position {position.XCoordinate},{position.YCoordinate} has already been played.");
            }
        }

        private static bool CoordinateOutOfRange(int coord)
        {
            return coord < 0 || coord > 2;
        }

        private char GetCurrentPlayer()
        {
            return playerList[turnNumber % 2];
        }

        private bool CheckWinConditions(BoardPosition position, char currentPlayer)
        {
            if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
            {
                return true;
            }

            if (board[2, 0] == currentPlayer && board[1, 1] == currentPlayer && board[0, 2] == currentPlayer)
            {
                return true;
            }

            return CheckHorizontalAndVerticalWinConditions(position, currentPlayer);
        }

        private bool CheckHorizontalAndVerticalWinConditions(BoardPosition position, char currentPlayer)
        {
            var hasVerticalWon = true;
            var hasHorizontalWon = true;

            for (int i = 0; i < 3; i++)
            {
                if (board[position.XCoordinate, i] != currentPlayer)
                {
                    hasVerticalWon = false;
                }

                if (board[i, position.YCoordinate] != currentPlayer)
                {
                    hasHorizontalWon = false;
                }
            }

            return hasVerticalWon || hasHorizontalWon;
        }
    }
}