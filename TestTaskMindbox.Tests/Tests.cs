using NUnit.Framework;
using System;
using TestTaskMindbox.Figures;

namespace TestTaskMindbox.Tests
{
    public class Tests
    {
        [Test]
        public void Circle_GetArea_ReturnsCorrectValue()
        {
            double radius = 5;
            var circle = new Circle(radius);

            var expected = Math.PI * radius * radius;
            var actual = circle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_GetArea_ReturnsCorrectValue()
        {
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);

            var p = (sideA + sideB + sideC) / 2;
            var expected = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            var actual = triangle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_IsRightAngled_ReturnsTrue()
        {
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);

            var expected = true;
            var actual = triangle.IsRightAngled();

            Assert.AreEqual(expected, actual);
        }
    }
}