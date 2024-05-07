using SquareShapeLibrary.Models;

namespace SquareShapeLibrary.Interfaces
{
    public interface IShapeCalculator
    {
        double AreaCalculate(Shape shape);
        bool IsRightTriangle(Triangle triangle);
    }
}
