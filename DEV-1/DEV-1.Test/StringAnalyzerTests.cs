using NUnit.Framework;
using DEV_1;

namespace Tests
{
    [TestFixture]
    public class StringAnalyzerTests
    {
        [TestCase(0, null)]
        [TestCase(0, "")]
        [TestCase(0, "a")]
        [TestCase(0, "abc cde")]
        [TestCase(0, "abcDdefg")]
        [TestCase(2, "abcDDefg")]
        [TestCase(2, "abcddefg")]
        [TestCase(3, "abcddccc")]
        [TestCase(4, "abccccvvddccc")]
        [TestCase(3, "abbc12223d")]
        [TestCase(3, "abbc~#+++d")]
        [TestCase(3, "abcdefgh abcdefgh abcdefgh abcdefgh abcdefgh abcdefgh abcdefgh abcdefgh abcdefgh abcdefgh abcdefgh abcdefgh abcdefgh abcdefgh abcdefgh abcdefghhh")]
        [TestCase(2, "abc  def")]
        public void ToCountSameCharacters_Test(int correctAnswer, string inputString)
        {
            Assert.AreEqual(correctAnswer, StringAnalyzer.ToCountSameCharacters(inputString));
        }
    }
}