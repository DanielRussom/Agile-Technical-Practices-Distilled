namespace Agile_Technical_Practices_Distilled.Tests.Chapter_2
{
    public class FibonacciGenerator
    {
        private int previousNumber = 0;
        private int currentNumber = 1;

        public FibonacciGenerator()
        {
        }

        public int Generate(int position)
        {
            if (position == 1)
            {
                return previousNumber;
            }

            CalculateNumber(position);

            return currentNumber;
        }

        private void CalculateNumber(int position)
        {
            for (int i = 3; i <= position; i++)
            {
                var newNumber = currentNumber + previousNumber;
                previousNumber = currentNumber;
                currentNumber = newNumber;
            }
        }
    }
}