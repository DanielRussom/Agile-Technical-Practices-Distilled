namespace Agile_Technical_Practices_Distilled.Chapter_5.GameOfLife
{
    public class LifeBoard
    {
        public bool Equals(int[,] toCompare)
        {
            for (int x = 0; x < toCompare.GetLength(0); x++)
            {
                for (int y = 0; y < toCompare.GetLength(1); y++)
                {
                    if (toCompare[x, y] == 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}