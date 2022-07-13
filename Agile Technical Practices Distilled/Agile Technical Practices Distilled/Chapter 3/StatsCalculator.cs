namespace Agile_Technical_Practices_Distilled.Chapter_3
{
    public class StatsCalculator
    {
        public StatsCalculator()
        {
        }

        public StatsCalculatorResults Calculate(List<int> input)
        {
            var minimumValue = 0;

            if (input.Contains(1))
            {
                minimumValue = 1;
            }

            return new StatsCalculatorResults { MinimumValue = minimumValue };
        }
    }
}