using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;

namespace TestTaskUnitTests
{
    [TestClass]
    public class CircleAreaTests
    {
        [TestMethod]
        public void CalculateArea_10_314returned()
        {
            //arrange
            var radius = 10;
            double expected = 314.1593;

            //act
            var circleArea = new CircleArea(radius);
            var actual = circleArea.CalculateArea();

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
