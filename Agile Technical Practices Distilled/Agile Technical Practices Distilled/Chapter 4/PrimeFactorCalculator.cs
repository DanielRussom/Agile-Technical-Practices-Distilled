namespace Agile_Technical_Practices_Distilled.Chapter_4
{
    public class PrimeFactorCalculator
    {
        public IList<int> Calculate(int input)
        {
            if(input > 1)
            {
                return new List<int> { 2 };
            }

            return new List<int> { 1 };
        }
    }
}