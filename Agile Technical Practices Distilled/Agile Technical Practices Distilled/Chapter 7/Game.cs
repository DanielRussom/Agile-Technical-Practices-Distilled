namespace Agile_Technical_Practices_Distilled.Chapter_7
{
    public class Game
    {
        private char lastPlayedSymbol = ' ';
        private Board _board = new();
        
        public void Play(char symbol, int x, int y)
        {
            var newMove = new Tile { XPosition= x, YPosition = y, Symbol = symbol };

            ValidateMove(newMove);

            lastPlayedSymbol = symbol;
            _board.ChangeSymbolAtTileLocation(symbol, x, y);
        }

        private void ValidateMove(Tile newMove)
    {
            if (FirstMovePlayedIsNotX(newMove.Symbol))
            {
                throw new Exception("Invalid first player");
            }

            if (newMove.Symbol == lastPlayedSymbol)
            {
                throw new Exception("Invalid next player");
            }

            if (_board.SymbolAt(newMove.XPosition, newMove.YPosition) != ' ')
            {
                throw new Exception("Invalid position");
            }
        }

        private bool FirstMovePlayedIsNotX(char symbol)
        {
            return lastPlayedSymbol == ' ' && symbol == 'O';
        }

        public char Winner()
        {   //if the positions in first row are taken
            if(_board.TileAt(0, 0).Symbol != ' ' &&
               _board.TileAt(0, 1).Symbol != ' ' &&
               _board.TileAt(0, 2).Symbol != ' ')
               {
                    //if first row is full with same symbol
                    if (_board.TileAt(0, 0).Symbol == 
                        _board.TileAt(0, 1).Symbol &&
                        _board.TileAt(0, 2).Symbol == 
                        _board.TileAt(0, 1).Symbol )
                        {
                            return _board.TileAt(0, 0).Symbol;
                        }
               }
                
             //if the positions in first row are taken
             if(_board.TileAt(1, 0).Symbol != ' ' &&
                _board.TileAt(1, 1).Symbol != ' ' &&
                _board.TileAt(1, 2).Symbol != ' ')
                {
                    //if middle row is full with same symbol
                    if (_board.TileAt(1, 0).Symbol == 
                        _board.TileAt(1, 1).Symbol &&
                        _board.TileAt(1, 2).Symbol == 
                        _board.TileAt(1, 1).Symbol)
                        {
                            return _board.TileAt(1, 0).Symbol;
                        }
                }

            //if the positions in first row are taken
             if(_board.TileAt(2, 0).Symbol != ' ' &&
                _board.TileAt(2, 1).Symbol != ' ' &&
                _board.TileAt(2, 2).Symbol != ' ')
                {
                    //if middle row is full with same symbol
                    if (_board.TileAt(2, 0).Symbol == 
                        _board.TileAt(2, 1).Symbol &&
                        _board.TileAt(2, 2).Symbol == 
                        _board.TileAt(2, 1).Symbol)
                        {
                            return _board.TileAt(2, 0).Symbol;
                        }
                }

            return ' ';
        }
    }
}