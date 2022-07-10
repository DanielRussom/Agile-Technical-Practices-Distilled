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
            var result = string.Empty;

            if (DivisibleBy(input, 3))
            {
                result += Fizz;
            }

            if (DivisibleBy(input, 5))
            {
                result += Buzz;
            }

            if (result.Length > 1)
            {
                return result;
            }

            return input.ToString();
        }

        private static bool DivisibleBy(int input, int value)
        {
            return input % value == 0;
        }
    }
}