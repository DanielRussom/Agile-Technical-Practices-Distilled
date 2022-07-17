namespace Agile_Technical_Practices_Distilled.Chapter_4
{
    public class RomanNumeralConverterV1
    {
        public string Convert(int input)
        {
            if(input == 3)
            {
                return "III";
            }

            if(input == 2)
            {
                return "II";
            }

            return "I";
        }
    }
}