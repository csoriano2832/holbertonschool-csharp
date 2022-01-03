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
        public void NoUniqueCharacters()
        {
            string s = "hellohello";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(-1));
        }
        [Test]
        public void FirstUniqueIsFirstCharacter()
        {
            string s = "helloworld";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void FirstUniqueInMiddle()
        {
            string s = "helloholberton";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(8));
        }
        [Test]
        public void FirstUniqueIsLastCharacter()
        {
            string s = "aabbccddeef";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(10));
        }
    }
}