using SquareShapeLibrary.Interfaces;
using SquareShapeLibrary.Models;

namespace SquareShapeLibrary.Services
{
    /// <summary>
    /// Класс вычислений площадей
    /// </summary>
    public class ShapeCalculator : IShapeCalculator
    {
        /// <summary>
        /// Метод вычисления площади для фигур
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public virtual double AreaCalculate(Shape shape)
        {
            switch (shape.Type)
            {
                case "Circle":
                    return CalculateCircle((Circle)shape);
                case "Triangle":
                    return CalculateTriangle((Triangle)shape);
            }
            return default;
        }

        /// <summary>
        /// Метод определяющий , является ли треугольник прямоугольный
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public virtual bool IsRightTriangle(Triangle triangle)
        {
            double[] sides = { triangle.SideA, triangle.SideB, triangle.SideC };
            Array.Sort(sides);
            var result = sides[2] * sides[2] == sides[1] * sides[1] + 
                sides[0] + sides[0];
            return result;
        }

        /// <summary>
        /// Защищенные методы нахождения площади треугольника и окружности
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        
        #region Protected Block
        protected virtual double CalculateTriangle(Triangle triangle)
        {
            var p = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            var formulaGeron = Math.Sqrt(p * (p - triangle.SideA) * 
                (p - triangle.SideB) * (p - triangle.SideC));
            return formulaGeron;
        }

        protected virtual double CalculateCircle(Circle circle)
        {
            var radius = circle.Radius;
            return Math.PI * radius * radius;
        }
        #endregion
    }
}
