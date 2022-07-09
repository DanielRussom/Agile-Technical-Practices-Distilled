using System;

namespace Agile_Technical_Practices_Distilled.Chapter_2
{
    public class FizzBuzzConverter
    {
        public FizzBuzzConverter()
        {
        }

        public string Convert(int input)
        {
            if(input % 3 == 0)
            {
                return "Fizz";
            }

            return input.ToString();
        }
    }
}