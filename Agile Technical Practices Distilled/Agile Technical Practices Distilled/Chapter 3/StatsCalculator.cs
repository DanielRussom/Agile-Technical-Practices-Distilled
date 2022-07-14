namespace Agile_Technical_Practices_Distilled.Chapter_3
{
    public class StatsCalculator
    {
        public StatsCalculator()
        {
        }

        public StatsCalculatorResults Calculate(List<int> input)
        {
            var result = new StatsCalculatorResults
            {
                MinimumValue = GetMinimumValue(input),

                MaximumValue = GetMaximumValue(input),

                ElementCount = GetElementCount(input),

                AverageValue = 1
            };

            return result;
        }

        private static int GetMinimumValue(List<int> input)
        {
            return input.Min();
        }

        private static int GetMaximumValue(List<int> input)
        {
            return input.Max();
        }

        private static int GetElementCount(List<int> input)
        {
            return input.Count;
        }
    }
}