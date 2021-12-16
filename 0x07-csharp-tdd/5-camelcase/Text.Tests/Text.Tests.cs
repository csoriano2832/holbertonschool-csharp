using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    /// <summary>Tests Alz</summary>
    public class Tests
    {
        [Test]
        public void EmptyString()
        {
            string s = "";
            
            int result = Str.CamelCase(s);

            Assert.AreEqual(0, result);
        }
        [Test]
        public void NullString()
        {
            string s = null;
            
            int result = Str.CamelCase(s);

            Assert.AreEqual(0, result);
        }
        [Test]
        public void ReturnsCorrectNumber()
        {
            string s = "soThisIsATestToSeeIfItWorks";
            
            int result = Str.CamelCase(s);

            Assert.AreEqual(10, result);
        }
    }
}