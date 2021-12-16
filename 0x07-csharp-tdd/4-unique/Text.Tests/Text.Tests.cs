using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsEmpty()
        {
            string s = "";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(-1));
        }
        [Test]
        public void OnlyRepeatingChars()
        {
            string s = "wwwwwwwwwwwwwwwwwwwwwwwww";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(-1));
        }
        [Test]
        public void ReturnsCorrectIndex()
        {
            string s = "abcdefghijklmnopqrstuvwxyzabcdfghijkzxywvutsrponlm";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(4));
        }
        
    }
}