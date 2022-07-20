namespace Agile_Technical_Practices_Distilled.Tests.Chapter_4
{
    public class BooleanCalculator
    {
        public bool Calculate(string input)
        {
            var words = input.Split(' ');

            if (words[0].Equals("NOT"))
            {
                return !bool.Parse(words[1]);
            }

            return bool.Parse(input);
        }
    }
}