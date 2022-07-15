using Agile_Technical_Practices_Distilled.Chapter_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_3
{
    [TestClass]
    public class AnagramGeneratorShould
    {
        private AnagramGenerator UnderTest;

        public AnagramGeneratorShould()
        {
            UnderTest = new AnagramGenerator();
        }

        [TestMethod]
        public void Generate_one_anagram()
        {
            var input = "a";

            var result = UnderTest.Generate(input);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("a", result[0]);
        }

        [TestMethod]
        public void Generate_two_anagrams()
        {
            var input = "ab";

            var result = UnderTest.Generate(input);

            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Contains("ab"));
            Assert.IsTrue(result.Contains("ba"));
        }
    }
}
