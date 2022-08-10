namespace Agile_Technical_Practices_Distilled.Chapter_7
{
    public class Board
    {
       private List<Tile> boardTiles = new();
       
        public Board()
        {
            for (int xCoord = 0; xCoord < 3; xCoord++)
            {
                for (int yCoord = 0; yCoord < 3; yCoord++)
                {
                    boardTiles.Add(new Tile{ XPosition = xCoord, YPosition = yCoord, Symbol = ' '});
                }  
            }       
        }

       public Tile TileAt(int xCoord, int yCoord)
       {
           return boardTiles.Single(tile => tile.XPosition == xCoord && tile.YPosition == yCoord);
        }

        public char SymbolAt(int xCoord, int yCoord)
        {
            var tile = TileAt(xCoord, yCoord);
            return tile.Symbol;
        }

        public void ChangeSymbolAtTileLocation(char symbol, int xCoord, int yCoord)
       {
            var tile = TileAt(xCoord, yCoord);
            tile.Symbol = symbol;
       }
    }
}