namespace Agile_Technical_Practices_Distilled.Chapter_2
{
    public class FizzBuzzConverter
    {
        public FizzBuzzConverter()
        {
        }

        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        public string Convert(int input)
        {
            if (DivisibleBy(input, 15))
            {
                return Fizz + Buzz;
            }

            if (DivisibleBy(input, 3))
            {
                return Fizz;
            }

            if (DivisibleBy(input, 5))
            {
                return Buzz;
            }

            return input.ToString();
        }

        private static bool DivisibleBy(int input, int value)
        {
            return input % value == 0;
        }
    }
}