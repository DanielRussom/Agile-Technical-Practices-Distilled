﻿namespace Agile_Technical_Practices_Distilled.Chapter_5.GameOfLife
{
    public class LifeBoard
    {
        public bool Equals(int[,] toCompare)
        {
            if(toCompare[0,0] == 1)
            {
                return false;
            }

            return true;
        }
    }
}