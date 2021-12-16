using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTwoNumbers()
        {
            var result = Operations.Add(1, 1);
            Assert.AreEqual(2, result);
            
            result = Operations.Add(-1, -1);
            Assert.AreEqual(-2, result);
            
            result = Operations.Add(0, 0);
            Assert.AreEqual(0, result);
        }
    }
}