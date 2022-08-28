namespace Agile_Technical_Practices_Distilled.Chapter_5.GameOfLife
{
    public class LifeBoard
    {
        public bool Equals(int[,] toCompare)
        {
            var rowEquality = new List<bool>();
            for (int x = 0; x < toCompare.GetLength(0); x++)
            {
                rowEquality.Add(RowEquals(toCompare, x));
            }

            return AllValuesAreEqual(rowEquality);
        }

        private static bool RowEquals(int[,] toCompare, int x)
        {
            var cellEquality = new List<bool>();
            for (int y = 0; y < toCompare.GetLength(1); y++)
            {
                cellEquality.Add(CellEquals(toCompare, x, y));
            }

            return AllValuesAreEqual(cellEquality);
        }

        private static bool CellEquals(int[,] toCompare, int x, int y)
        {
            return toCompare[x, y] != 1;
        }

        private static bool AllValuesAreEqual(List<bool> valuesToCheck)
        {
            return valuesToCheck.All(x => x == true);
        }
    }
}