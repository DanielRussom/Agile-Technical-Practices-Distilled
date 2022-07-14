namespace Agile_Technical_Practices_Distilled.Chapter_3
{
    public class StatsCalculator
    {
        private int minimumValue;
        private int maximumValue;
        private int elementCount;

        public StatsCalculator()
        {
        }

        public StatsCalculatorResults Calculate(List<int> input)
        {
            var result = new StatsCalculatorResults();

            minimumValue = GetMinimumValue(input);

            maximumValue = GetMaximumValue(input);

            elementCount = GetElementCount(input);

            return BuildResults();
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

        private StatsCalculatorResults BuildResults()
        {
            return new StatsCalculatorResults { MinimumValue = minimumValue, MaximumValue = maximumValue, ElementCount = elementCount };
        }
    }
}