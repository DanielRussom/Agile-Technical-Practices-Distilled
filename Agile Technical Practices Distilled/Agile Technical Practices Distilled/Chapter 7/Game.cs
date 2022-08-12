namespace Agile_Technical_Practices_Distilled.Chapter_7
{
    public class Game
    {
        private char lastPlayedSymbol = ' ';
        private Board _board = new();
        
        public void Play(char symbol, int x, int y)
        {
            var newMove = new Tile { XPosition = x, YPosition = y, Symbol = symbol };

            ValidateMove(newMove);

            lastPlayedSymbol = symbol;
            _board.ChangeSymbolAtTileLocation(symbol, x, y);
        }

        private void ValidateMove(Tile newMove)
    {
            if (FirstSymbolPlayedIsNotValid(newMove.Symbol))
            {
                throw new Exception("Invalid first player");
            }

            if (newMove.Symbol == lastPlayedSymbol)
            {
                throw new Exception("Invalid next player");
            }

            if (_board.SymbolsIsNotEmptyAt(newMove.XPosition, newMove.YPosition))
            {
                throw new Exception("Invalid position");
            }
        }

        private bool FirstSymbolPlayedIsNotValid(char symbol)
        {
            return lastPlayedSymbol == ' ' && symbol == 'O';
        }

        public char Winner()
        {
            for (int row = 0; row < 3; row++)
            {
                if (RowSymbolsAreSetAndMatch(row))
                {
                    return _board.SymbolAt(row, 0);
                }
            }

            return ' ';
        }

        private bool RowSymbolsAreSetAndMatch(int row)
        {
            return _board.SymbolsMatchInRow(row) 
                && _board.SymbolsIsNotEmptyAt(row, 0);
        }
    }
}