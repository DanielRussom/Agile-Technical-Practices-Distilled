namespace Agile_Technical_Practices_Distilled.Chapter_4
{
    public class PrimeFactorCalculator
    {
        public List<int> Calculate(int input)
        {
            var primeFactors = new List<int>();

            var divisor = 2;

            while (input > 1)
            {
                while (input % divisor == 0)
                {
                    primeFactors.Add(divisor);
                    input /= divisor;
                }

                divisor++;
            }

            if (input > 1)
            {
                primeFactors.Add(input);
            }

            return primeFactors;
        }
    }
}