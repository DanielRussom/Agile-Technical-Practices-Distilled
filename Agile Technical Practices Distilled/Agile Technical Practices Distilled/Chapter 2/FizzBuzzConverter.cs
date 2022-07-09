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

            if (input % 3 == 0)
            {
                result += Fizz;
            }

            if (input % 5 == 0) 
            {
                result += Buzz; 
            }

            if (result.Length > 1)
            {
                return result;
            }

            return input.ToString();
        }
    }
}