namespace Agile_Technical_Practices_Distilled.Tests.Chapter_2
{
    public class FibonacciGenerator
    {
        public FibonacciGenerator()
        {
        }

        public int Generate(int position)
        {
            if(position == 2) {
                return 1;
            }

            return 0;
        }
    }
}