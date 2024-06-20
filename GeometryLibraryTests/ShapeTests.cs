using System;
using GeometryLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryLibraryTests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void TestCircleArea()
        {
            Circle circle = new Circle(5);
            double expected = Math.PI * 25;
            Assert.AreEqual(expected, circle.CalculateArea(), 1e-10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCircleInvalidRadius()
        {
            Circle circle = new Circle(-5);
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 6;
            Assert.AreEqual(expected, triangle.CalculateArea(), 1e-10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTriangleInvalidSides()
        {
            Triangle triangle = new Triangle(1, 2, 3);
        }

        [TestMethod]
        public void TestRightTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [TestMethod]
        public void TestNotRightTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRightTriangle());
        }
    }
}
