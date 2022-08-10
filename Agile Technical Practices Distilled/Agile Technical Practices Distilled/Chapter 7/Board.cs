namespace Agile_Technical_Practices_Distilled.Chapter_7
{
    public class Board
    {
       private List<Tile> _plays = new();
       
        public Board()
        {
            for (int xCoord = 0; xCoord < 3; xCoord++)
            {
                for (int yCoord = 0; yCoord < 3; yCoord++)
                {
                    _plays.Add(new Tile{ XPosition = xCoord, YPosition = yCoord, Symbol = ' '});
                }  
            }       
        }

       public Tile TileAt(int x, int y)
       {
           return _plays.Single(tile => tile.XPosition == x && tile.YPosition == y);
       }

       public void AddTileAt(char symbol, int x, int y)
       {
           var newTile = new Tile
           {
               XPosition = x,
               YPosition = y,
               Symbol = symbol
           };

           _plays.Single(tile => tile.XPosition == x && tile.YPosition == y).Symbol = symbol;
       }
    }
}