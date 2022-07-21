namespace Agile_Technical_Practices_Distilled.Tests.Chapter_4
{
    public class BooleanCalculator
    {
        public bool Calculate(string input)
        {
            if (input.Contains("("))
            {
                var parenthesesConditions = input.Split('(', ')');
                var result = Calculate(parenthesesConditions[1]);

                parenthesesConditions[1] = result.ToString();

                input = String.Join("", parenthesesConditions);
            }

            if (input.Contains("AND"))
            {
                var andConditions = input.Split(" AND ");
                var result = Calculate(andConditions[0]);

                for(int i = 1; i < andConditions.Length; i++)
                {
                    result = result && Calculate(andConditions[i]);
                }

                return result;
            }

            if (input.Contains("OR"))
            {
                var orConditions = input.Split(" OR ");
                var result = Calculate(orConditions[0]);

                for (int i = 1; i < orConditions.Length; i++)
                {
                    result = result || Calculate(orConditions[i]);
                }

                return result;
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