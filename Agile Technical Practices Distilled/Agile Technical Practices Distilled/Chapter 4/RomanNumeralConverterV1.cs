﻿namespace Agile_Technical_Practices_Distilled.Chapter_4
{
    public class RomanNumeralConverterV1
    {
        public string Convert(int input)
        {
            var result = string.Empty;

            for(int i = 1; i <= input; i++)
            {
                result += "I";
            }

            return result;
        }
    }
}