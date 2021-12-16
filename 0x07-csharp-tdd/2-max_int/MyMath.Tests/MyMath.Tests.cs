using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetsMaxNumberSuccesfully()
        {
            List<int> nums = new List<int> {98, 1024, -98, 0, 64, -512};
            var result = Operations.Max(nums);

            Assert.AreEqual(1024, result);
        }

        [Test]
        public void VoidListReturns()
        {
            List<int> nums = new List<int>();
            var result = Operations.Max(nums);

            Assert.AreEqual(0, result);
        }
    }
}