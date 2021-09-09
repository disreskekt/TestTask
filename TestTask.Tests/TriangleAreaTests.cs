using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;

namespace TestTaskUnitTests
{
    [TestClass]
    public class TriangleAreaTests
    {
        [TestMethod]
        public void CalculateArea_RightTriangle3and4and5_6Returned()
        {
            //arrange
            var a = 3;
            var b = 4;
            var c = 5;
            double expected = 6;

            //act
            var triangleArea = new TriangleArea(a, b, c);
            var actual = triangleArea.CalculateArea();

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void CalculateIsRight_3and4and5_TrueReturned()
        {
            //arrange
            var a = 3;
            var b = 4;
            var c = 5;
            bool expected = true;

            //act
            var triangleArea = new TriangleArea(a, b, c);
            var actual = triangleArea.CalculateIsRight();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateArea_13and13and10_60Returned()
        {
            //arrange
            var a = 13;
            var b = 13;
            var c = 10;
            double expected = 60;

            //act
            var triangleArea = new TriangleArea(a, b, c);
            var actual = triangleArea.CalculateArea();

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void CalculateIsRight_13and13and10_FalseReturned()
        {
            //arrange
            var a = 13;
            var b = 13;
            var c = 10;
            bool expected = false;

            //act
            var triangleArea = new TriangleArea(a, b, c);
            var actual = triangleArea.CalculateIsRight();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
