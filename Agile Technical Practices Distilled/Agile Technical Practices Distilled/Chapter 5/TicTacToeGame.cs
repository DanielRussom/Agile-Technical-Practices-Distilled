namespace Agile_Technical_Practices_Distilled.Chapter_5
{
    public class TicTacToeGame
    {
        private char[,] board;

        public TicTacToeGame()
        {
            board = new char[3, 3];
        }

        public void Play(int xCoord, int yCoord)
        {
            board[1, 1] = 'X';
        }

        public char[,] GetBoard()
        {
            return board;
        }
    }
}