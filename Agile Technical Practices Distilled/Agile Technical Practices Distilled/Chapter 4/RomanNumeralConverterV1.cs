namespace Agile_Technical_Practices_Distilled.Chapter_4
{
    public class RomanNumeralConverterV1
    {
        public string Convert(int input)
        {
            var result = string.Empty;

            if (input >= 10)
            {
                input -= 10;
                result += "X";
            }

            if (input >= 5)
            {
                input -= 5;
                result += "V";
            }

            while (input > 0)
            {
                input -= 1;
                result += "I";
            }

            return result;
        }
    }
}