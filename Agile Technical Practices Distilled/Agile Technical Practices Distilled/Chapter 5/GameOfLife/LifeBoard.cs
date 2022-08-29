using Agile_Technical_Practices_Distilled.Chapter_8;

namespace Agile_Technical_Practices_Distilled.Chapter_5.GameOfLife
{
    public class LifeBoard
    {
        private readonly ILifeBoardDisplayer displayer;

        public LifeBoard(ILifeBoardDisplayer displayer)
        {
            this.displayer = displayer;
        }

        public void DisplayBoard()
        {
            displayer.DisplayBoard(new int[3, 3]);
        }
    }
}