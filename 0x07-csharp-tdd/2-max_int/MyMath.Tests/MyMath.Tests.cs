using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmptyList()
        {
            List<int> nums = new List<int>();
            int output = MyMath.Operations.Max(nums);
            Assert.That(output, Is.EqualTo(0));
        }

        [Test]
        public void TestMaxList()
        {
            List<int> nums = new List<int>() {98, -10, 0, 32, 972, 12, 1024, -727, -98, 50, 8};
            int output = MyMath.Operations.Max(nums);
            Assert.That(output, Is.EqualTo(1024));
        }

        [Test]
        public void TestMaxAtEnd()
        {
            List<int> nums = new List<int>() {98, -10, 0, 32, 972, 12, -727, -98, 50, 8, 1024};
            int output = MyMath.Operations.Max(nums);
            Assert.That(output, Is.EqualTo(1024));
        }

        [Test]
        public void TestMaxAtBeginning()
        {
            List<int> nums = new List<int>() {1024, 98, -10, 0, 32, 972, 12, -727, -98, 50, 8};
            int output = MyMath.Operations.Max(nums);
            Assert.That(output, Is.EqualTo(1024));
        }

        [Test]
        public void TestNegativeNumberInList()
        {
            List<int> nums = new List<int>() {-20, -17, -8, -100, -1};
            int output = MyMath.Operations.Max(nums);
            Assert.That(output, Is.EqualTo(-1));
        }
    }
}
