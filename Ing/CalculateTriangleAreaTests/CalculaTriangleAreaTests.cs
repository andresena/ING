using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ing.tests
{
    [TestClass()]
    public class CalculaTriangleAreaTests
    {
        [TestMethod()]
        public void VerifyIfEquilateralTriangleAreaIsCorrect()
        {
            CalculateTriangleArea calculatetrianglearea = new CalculateTriangleArea();

            double result = calculatetrianglearea.calculateTriangleArea(5, 5, 5);

            double expectedResult = 10.825;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void VerifyIfIsoscelesTriangleAreaIsCorrect()
        {
            CalculateTriangleArea calculatetrianglearea = new CalculateTriangleArea();

            double result = calculatetrianglearea.calculateTriangleArea(5, 5, 6);

            double expectedResult = 12;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void VerifyIfEscalenoTriangleAreaIsCorrect()
        {
            CalculateTriangleArea calculatetrianglearea = new CalculateTriangleArea();

            double result = calculatetrianglearea.calculateTriangleArea(5, 6, 7);

            double expectedResult = 14.697;

            Assert.AreEqual(expectedResult, result);
        }
    }
}