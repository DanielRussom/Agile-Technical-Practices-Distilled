namespace Agile_Technical_Practices_Distilled.Chapter_5
{
    public class TicTacToeGame
    {
        private char[,] board;
        private char nextPlayer;

        public TicTacToeGame()
        {
            board = new char[3, 3];
            nextPlayer = 'X';
        }

        public void Play(int xCoord, int yCoord)
        {
            board[xCoord, yCoord] = nextPlayer;

            if(nextPlayer == 'X')
            {
                nextPlayer = 'O';
            } 
            else if (nextPlayer == 'O')
            {
                nextPlayer = 'X';
            }
        }

        public char[,] GetBoard()
        {
            return board;
        }
    }
}