namespace Agile_Technical_Practices_Distilled.Chapter_3
{
    public class AnagramGenerator
    {
        public List<string> Generate(string input)
        {
            var generatedAnagrams = new List<string>();

            if (input.Length == 1)
            {
                generatedAnagrams.Add(input);
                return generatedAnagrams;
            }

            for (int i = 0; i < input.Length; i++)
            {
                generatedAnagrams.AddRange(GetSubstringAnagrams(i, input));
            }

            return generatedAnagrams;
        }

        private List<string> GetSubstringAnagrams(int currentCharacterIndex, string input)
        {
            var substringAnagrams = new List<string>();

            var currentCharacter = input[currentCharacterIndex].ToString();
            var remainingCharacters = GetRemainingCharacters(input, currentCharacterIndex);
            
            var generatedSubAnagrams = Generate(remainingCharacters);

            foreach (var anagram in generatedSubAnagrams)
            {
                substringAnagrams.Add(currentCharacter + anagram);
            }

            return substringAnagrams;
        }

        private static string GetRemainingCharacters(string input, int currentCharacterIndex)
        {
            return string.Concat(input.AsSpan(0, currentCharacterIndex), input.AsSpan(currentCharacterIndex + 1));
        }
    }
}