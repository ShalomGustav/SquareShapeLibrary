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
            var expectedResult = 6; //��������(������� 6, � �������� ������� �� ������� 39)

            //action - ��������
            var actualResult = _service.AreaCalculate(triangle); //���������� ��������� �� ������

            //assert - ���������
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestCalculateCircle()
        {
            //arrange - ���������
            var circle = new Circle { Type = "Circle", Radius = 5 }; //������ ������ Circle
            var expectedResult = Math.PI * circle.Radius * circle.Radius; //��������

            //action - ��������
            var actualResult = _service.AreaCalculate(circle); ///���������� ��������� �� ������

            //assert - ���������
            Assert.Equal(expectedResult, actualResult);
        }
    }
}