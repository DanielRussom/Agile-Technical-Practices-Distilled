namespace Agile_Technical_Practices_Distilled.Tests.Chapter_2
{
    public class FibonacciGenerator
    {
        public FibonacciGenerator()
        {
        }

        public int Generate(int position)
        {
            if (position == 1)
            {
                return 0;
            }

            if (position == 2)
            {
                return 1;
            }

            return Generate(position - 1) + Generate(position);
        }
    }
}