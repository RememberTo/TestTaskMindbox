using System;
using TestTaskMindbox.Interfaces;

namespace TestTaskMindbox.Figures
{
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double GetArea()
        {
            var semiperimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - _sideA) * (semiperimeter - _sideB) * (semiperimeter - _sideC));
        }

        public bool IsRightAngled()
        {
            var maxSide = Math.Max(_sideA, Math.Max(_sideB, _sideC));
            var sumOfSquares = Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2);
            return sumOfSquares - 2 * Math.Pow(maxSide, 2) == 0;
        }
    }
}