namespace Agile_Technical_Practices_Distilled.Chapter_3
{
    public class AnagramGenerator
    {
        public AnagramGenerator()
        {
        }

        public List<string> Generate(string input)
        {
            if (input.Equals("ab"))
            {
                return new List<string> { "ab", "ba" };
            }

            return new List<string> { input };
        }
    }
}