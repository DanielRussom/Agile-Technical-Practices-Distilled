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
        [DataRow ("a")]
        [DataRow ("b")]
        [DataRow ("c")]
        public void Generate_one_anagram_matching_the_input(string input)
        {
            var result = UnderTest.Generate(input);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(input, result[0]);
        }
                
        [TestMethod]
        public void Generate_two_anagrams_for_ab()
        {
            var input = "ab";

            var result = UnderTest.Generate(input);

            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Contains("ab"));
            Assert.IsTrue(result.Contains("ba"));
        }

        [TestMethod]
        public void Generate_two_anagrams_for_cd()
        {
            var input = "cd";

            var result = UnderTest.Generate(input);

            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Contains("cd"));
            Assert.IsTrue(result.Contains("dc"));
        }

        [TestMethod]
        public void Generate_two_anagrams_for_ef()
        {
            var input = "ef";

            var result = UnderTest.Generate(input);

            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Contains("ef"));
            Assert.IsTrue(result.Contains("fe"));
        }

        [TestMethod]
        public void Generate_anagrams_for_abc()
        {
            var input = "abc";

            var result = UnderTest.Generate(input);

            Assert.AreEqual(6, result.Count);
            Assert.IsTrue(result.Contains("abc"));
            Assert.IsTrue(result.Contains("acb"));
            Assert.IsTrue(result.Contains("bac"));
            Assert.IsTrue(result.Contains("bca"));
            Assert.IsTrue(result.Contains("cab"));
            Assert.IsTrue(result.Contains("cba"));
        }

        [TestMethod]
        public void Generate_anagrams_for_dad_without_duplicates()
        {
            var input = "dad";

            var result = UnderTest.Generate(input);

            Assert.AreEqual(3, result.Count);
            Assert.IsTrue(result.Contains("dad"));
            Assert.IsTrue(result.Contains("dda"));
            Assert.IsTrue(result.Contains("add"));
        }
    }
}
