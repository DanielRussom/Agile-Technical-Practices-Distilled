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

            if(input.Length > 1)
            {
                generatedAnagrams.Add(input[1].ToString() + input[0].ToString());
            }

            generatedAnagrams.Add(input);

            return generatedAnagrams;
        }
    }
}