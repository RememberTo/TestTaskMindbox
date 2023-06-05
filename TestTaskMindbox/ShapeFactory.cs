using TestTaskMindbox.Figures;
using TestTaskMindbox.Interfaces;

namespace TestTaskMindbox
{
    public class ShapeFactory
    {
        public IShape CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public IShape CreateTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }
    }

}
