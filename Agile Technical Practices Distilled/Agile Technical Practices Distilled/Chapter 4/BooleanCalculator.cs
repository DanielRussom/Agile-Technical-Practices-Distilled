namespace Agile_Technical_Practices_Distilled.Tests.Chapter_4
{
    public class BooleanCalculator
    {
        private readonly char[] PARENTHESES = { '(', ')' };
        private const string AND_COMMAND = "AND";
        private const string OR_COMMAND = "OR";
        private const string NOT_COMMAND = "NOT";

        public bool Calculate(string input)
        {
            if (input.Contains(PARENTHESES[0]))
            {
                input = GetConvertedParenthesesLogic(input);
            }

            if (input.Contains(AND_COMMAND))
            {
                return CalculateAndLogic(input);
            }

            if (input.Contains(OR_COMMAND))
            {
                return CalculateOrLogic(input);
            }

            if (input.StartsWith(NOT_COMMAND))
            {
                var value = input.Substring(NOT_COMMAND.Length + 1);
                return !bool.Parse(value);
            }

            return bool.Parse(input);
        }

        private string GetConvertedParenthesesLogic(string input)
        {
            var parenthesesConditions = input.Split(PARENTHESES);
            var result = Calculate(parenthesesConditions[1]);

            parenthesesConditions[1] = result.ToString();

            input = string.Join(string.Empty, parenthesesConditions);
            return input;
        }

        private bool CalculateAndLogic(string input)
        {
            var andConditions = input.Split($" {AND_COMMAND} ");
            var result = Calculate(andConditions[0]);

            for (int i = 1; i < andConditions.Length; i++)
            {
                result = result && Calculate(andConditions[i]);
            }

            return result;
        }

        private bool CalculateOrLogic(string input)
        {
            var orConditions = input.Split($" {OR_COMMAND} ");
            var result = Calculate(orConditions[0]);

            for (int i = 1; i < orConditions.Length; i++)
            {
                result = result || Calculate(orConditions[i]);
            }

            return result;
        }
    }
}