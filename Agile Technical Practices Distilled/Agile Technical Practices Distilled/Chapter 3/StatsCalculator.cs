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

            var maximumValue = 1;

            return BuildResults(minimumValue, maximumValue);
        }

        private static int GetMinimumValue(List<int> input)
        {
            return input.Min();
        }

        private static StatsCalculatorResults BuildResults(int minimumValue, int maximumValue)
        {
            return new StatsCalculatorResults { MinimumValue = minimumValue, MaximumValue = maximumValue };
        }
    }
}