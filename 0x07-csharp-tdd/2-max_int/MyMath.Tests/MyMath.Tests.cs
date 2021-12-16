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
            List<int> nums = new List<int> {3, 4, 7, 2, 10};
            var result = Operations.Max(nums);

            Assert.AreEqual(10, result);
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