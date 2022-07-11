namespace Agile_Technical_Practices_Distilled.Chapter_2
{
    public class LeapYearValidator
    {
        public LeapYearValidator()
        {
        }

        public bool Validate(int input)
        {
            if (IsDivisibleBy(input, 400))
            {
                return true;
            }

            if (IsDivisibleBy(input, 100))
            {
                return false;
            }

            return IsDivisibleBy(input, 4);
        }

        private static bool IsDivisibleBy(int input, int divider)
        {
            return input % divider == 0;
        }
    }
}