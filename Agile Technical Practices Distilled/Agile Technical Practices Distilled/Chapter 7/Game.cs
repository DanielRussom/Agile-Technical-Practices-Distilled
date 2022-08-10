﻿namespace Agile_Technical_Practices_Distilled.Chapter_7
{
    public class Game
    {
        private char lastPlayedSymbol = ' ';
        private Board _board = new();
        
        public void Play(char symbol, int x, int y)
        {
            ValidateMove(symbol, x, y);

            lastPlayedSymbol = symbol;
            _board.ChangeSymbolAtTileLocation(symbol, x, y);
        }

        private void ValidateMove(char symbol, int x, int y)
        {
            if (FirstMovePlayedIsNotX(symbol))
            {
                throw new Exception("Invalid first player");
            }

            if (symbol == lastPlayedSymbol)
            {
                throw new Exception("Invalid next player");
            }

            if (_board.TileAt(x, y).Symbol != ' ')
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