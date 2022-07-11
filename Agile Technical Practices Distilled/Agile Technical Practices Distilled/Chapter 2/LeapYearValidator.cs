namespace Agile_Technical_Practices_Distilled.Chapter_2
{
    public class LeapYearValidator
    {
        public LeapYearValidator()
        {
        }

        public bool Validate(int input)
        {
            if (IsDivisibleBy(input, 100))
            {
                return false;
            }

            if (IsDivisibleBy(input, 4))
            {
                return true;
            }

            return false;
        }

        private static bool IsDivisibleBy(int input, int divider)
        {
            return input % divider == 0;
        }
    }
}