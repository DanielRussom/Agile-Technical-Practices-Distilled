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

       public Tile TileAt(int x, int y)
       {
           return boardTiles.Single(tile => tile.XPosition == x && tile.YPosition == y);
       }

       public void AddTileAt(char symbol, int x, int y)
       {
           boardTiles.Single(tile => tile.XPosition == x && tile.YPosition == y).Symbol = symbol;
       }
    }
}