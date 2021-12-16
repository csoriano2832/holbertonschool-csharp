using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void EmptyString()
        {
            string s = "";
            
            bool result = Str.IsPalindrome(s);

            Assert.AreEqual(true, result);
        }

        [TestCase("Racecar")]
        [TestCase("level")]
        public void IsNotCaseSensitive(string value)
        {   
            bool result = Str.IsPalindrome(value);

            Assert.AreEqual(true, result);
        }
        
        [Test]
        public void IgnoresSpacesPunctuations()
        {
            string s = "A man, a plan, a canal: Panama.";
            
            bool result = Str.IsPalindrome(s);

            Assert.AreEqual(true, result);
        }
    }
}