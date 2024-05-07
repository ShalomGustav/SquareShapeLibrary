using SquareShapeLibrary.Interfaces;
using SquareShapeLibrary.Models;
using SquareShapeLibrary.Services;
using Xunit;
namespace SquareShapeLibrary.Tests
{
    public class SquareShapeTest
    {
        private readonly IShapeCalculator _service = new ShapeCalculator();

        [Fact]
        public void TestCalculateTriangle()
        {
            //arrange 
            var triangle = new Triangle { Type = "Triangle", SideA = 5, SideB = 4, SideC = 3 };
            var expectedResult = 6; //ожидание(написал 6, в качестве примера со строкой 39)

            //action - действие
            var actualResult = _service.AreaCalculate(triangle); //актуальный результат из класса

            //assert - сравнение
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestCalculateCircle()
        {
            //arrange - настройка
            var circle = new Circle { Type = "Circle", Radius = 5 }; //обьект класса Circle
            var expectedResult = Math.PI * circle.Radius * circle.Radius; //ожидание

            //action - действие
            var actualResult = _service.AreaCalculate(circle); ///актуальный результат из класса

            //assert - сравнение
            Assert.Equal(expectedResult, actualResult);
        }
    }
}