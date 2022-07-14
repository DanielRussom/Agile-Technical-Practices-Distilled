namespace Agile_Technical_Practices_Distilled.Chapter_3
{
    public class StatsCalculator
    {
        public StatsCalculator()
        {
        }

        public StatsCalculatorResults Calculate(List<int> input)
        {
            var minimumValue = GetMinimumValue(input);

            var maximumValue = GetMaximumValue(input);

            return BuildResults(minimumValue, maximumValue);
        }

        private static int GetMinimumValue(List<int> input)
        {
            return input.Min();
        }

        private static int GetMaximumValue(List<int> input)
        {
            return input.Max();
        }

        private static StatsCalculatorResults BuildResults(int minimumValue, int maximumValue)
        {
            return new StatsCalculatorResults { MinimumValue = minimumValue, MaximumValue = maximumValue, ElementCount = 1 };
        }
    }
}