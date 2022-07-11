namespace Agile_Technical_Practices_Distilled.Chapter_2
{
    public class LeapYearValidator
    {
        public LeapYearValidator()
        {
        }

        public bool Validate(int input)
        {
            if (input % 4 == 0)
            {
                return true;
            }

            return false;
        }
    }
}