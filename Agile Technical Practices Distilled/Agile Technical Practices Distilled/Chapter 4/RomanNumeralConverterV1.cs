namespace Agile_Technical_Practices_Distilled.Chapter_4
{
    public class RomanNumeralConverterV1
    {
        public string Convert(int input)
        {
            var result = string.Empty;

            var romanNumerals = Enum.GetValues(typeof(RomanNumeralsEnumV1)).Cast<RomanNumeralsEnumV1>().Reverse();

            foreach (var numeral in romanNumerals)
            {
                while (input >= (int)numeral)
                {
                    input -= (int)numeral;
                    result += numeral;
                }
            }

            return result;
        }
    }
}