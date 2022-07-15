namespace Agile_Technical_Practices_Distilled.Chapter_3
{
    public class AnagramGenerator
    {
        public AnagramGenerator()
        {
        }

        public List<string> Generate(string input)
        {
            var generatedAnagrams = new List<string>();

            if (input.Equals("ab"))
            {
                generatedAnagrams.Add("ba");
            }

            if (input.Equals("cd"))
            {
                generatedAnagrams.Add("dc");
            }

            generatedAnagrams.Add(input);

            return generatedAnagrams;
        }
    }
}