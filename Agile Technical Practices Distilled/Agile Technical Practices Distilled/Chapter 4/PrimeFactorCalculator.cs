namespace Agile_Technical_Practices_Distilled.Chapter_4
{
    public class PrimeFactorCalculator
    {
        public List<int> Calculate(int input)
        {
            var primeFactors = new List<int>();

            if(input % 2 == 0)
            {
                primeFactors.Add(2);
                input /= 2;
            }

            if(input > 1)
            {
                primeFactors.Add(input);
            }

            return primeFactors;
        }
    }
}