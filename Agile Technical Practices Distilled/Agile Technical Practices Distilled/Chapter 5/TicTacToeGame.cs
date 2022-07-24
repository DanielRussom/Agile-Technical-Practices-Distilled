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

        public void Play(int xCoord, int yCoord)
        {
            var nextPlayer = GetNextPlayer();

            board[xCoord, yCoord] = nextPlayer;

            turnNumber++;
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