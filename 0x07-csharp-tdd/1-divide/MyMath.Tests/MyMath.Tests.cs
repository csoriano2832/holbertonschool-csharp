using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DividesSuccesfully()
        {
            int[,] matrix = {{2, 4}, {6, 8}};
            int[,] matrixDivided = {{1, 2}, {3, 4}};
            
            var result = Matrix.Divide(matrix, 2);
            Assert.IsNotNull(result);
            Assert.AreEqual(matrixDivided, result);
        }

        [Test]
        public void DivisionByZeroError()
        {
            int[,] matrix = {{2, 4}, {6, 8}};

            var result = Matrix.Divide(matrix, 0);
            Assert.IsNull(result);
        }
    }
}