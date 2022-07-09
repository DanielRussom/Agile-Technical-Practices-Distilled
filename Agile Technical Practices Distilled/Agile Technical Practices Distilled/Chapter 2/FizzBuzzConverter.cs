using System;

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
            if (input % 5 == 0) 
            { 
                return Buzz; 
            }

            if (input % 3 == 0)
            {
                return Fizz;
            }

            return input.ToString();
        }
    }
}