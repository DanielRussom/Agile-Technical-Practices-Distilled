namespace Agile_Technical_Practices_Distilled.Tests.Chapter_4
{
    public class BooleanCalculator
    {
        public bool Calculate(string input)
        {
            if (input.Contains("AND"))
            {
                var andConditions = input.Split(" AND ");
                return Calculate(andConditions[0]) && Calculate(andConditions[1]);
            }

            if (input.Contains("OR"))
            {
                var orConditions = input.Split(" OR ");
                return Calculate(orConditions[0]) || Calculate(orConditions[1]);
            }

            var words = input.Split(' ');
            if (words[0].Equals("NOT"))
            {
                return !bool.Parse(words[1]);
            }

            return bool.Parse(input);
        }
    }
}