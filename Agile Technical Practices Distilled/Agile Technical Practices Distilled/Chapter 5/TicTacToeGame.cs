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

        public void Play(BoardPosition position)
        {
            ValidateMove(position);

            var nextPlayer = GetNextPlayer();

            board[position.XCoordinate, position.YCoordinate] = nextPlayer;

            turnNumber++;
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

        private char GetNextPlayer()
        {
            return playerList[turnNumber % 2];
        }

        public char[,] GetBoard()
        {
            return board;
        }
    }
}