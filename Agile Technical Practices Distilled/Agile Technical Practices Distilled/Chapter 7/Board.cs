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

        public char SymbolAt(int xCoord, int yCoord)
        {
            var tile = TileAt(xCoord, yCoord);
            return tile.Symbol;
        }

        private Tile TileAt(int xCoord, int yCoord)
        {
            return boardTiles.Single(tile => tile.XPosition == xCoord && tile.YPosition == yCoord);
        }

        public void ChangeSymbolAtTileLocation(char symbol, int xCoord, int yCoord)
       {
            var tile = TileAt(xCoord, yCoord);
            tile.Symbol = symbol;
        }

        public bool SymbolsMatchInRow(int rowId)
        {
            var rowTiles = boardTiles.Where(x => x.XPosition == rowId );

            var firstSymbol = rowTiles.First().Symbol;

            return rowTiles.All(x => x.Symbol == firstSymbol);
        }

        public bool SymbolsIsNotEmptyAt(int xCoord, int yCoord)
        {
            var tile = TileAt(xCoord, yCoord);
            return tile.HasBeenSet();
        }
    }
}