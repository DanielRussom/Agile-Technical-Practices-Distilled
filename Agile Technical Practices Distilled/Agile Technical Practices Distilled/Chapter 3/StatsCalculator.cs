namespace Agile_Technical_Practices_Distilled.Chapter_3
{
    public class StatsCalculator
    {
        public StatsCalculator()
        {
        }

        public StatsCalculatorResults Calculate(List<int> input)
        {
            var minimumValue = input.Min();

            return new StatsCalculatorResults { MinimumValue = minimumValue };
        }
    }
}