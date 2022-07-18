namespace Agile_Technical_Practices_Distilled.Chapter_4
{
    public class RomanNumeralConverterV2
    {
        public string Convert(int input)
        {
            var result = string.Empty;

            if(input == 4)
            {
                result += "IV";
                input -= 4;
            }

            while (input > 0)
            {
                result += "I";
                input--;
            }
            
            return result;
        }
    }
}