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

            return new StatsCalculatorResults { MinimumValue = minimumValue };
        }

        private static int GetMinimumValue(List<int> input)
        {
            return input.Min();
        }
    }
}