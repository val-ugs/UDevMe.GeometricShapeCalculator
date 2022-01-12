using GeometricShapeCalculator.Shapes;
using NUnit.Framework;

namespace GeometricShapeCalculator.Tests
{
    public class TriangleTests
    {
        private ShapeFactory shapeFactory;

        [SetUp]
        public void Setup()
        {
            shapeFactory = new ShapeFactory();
        }

        [Test]
        public void TriangleCalculateSquare_ShouldReturnTrue()
        {
            // arrange
            var parameters = new ShapeParameters();
            parameters.SetParamater(ParameterNames.SideA, 2.1);
            parameters.SetParamater(ParameterNames.SideB, 3.3);
            parameters.SetParamater(ParameterNames.SideC, 1.6);

            var expectedValue = 1.3645512082732554;

            var shape = shapeFactory.CreateShape(parameters);

            // act
            var result = shape.CalculateSquare();

            // assert
            Assert.AreEqual(result, expectedValue);
        }

        [Test]
        public void TriangleCalculateSquare_ShouldReturnFalse()
        {
            // arrange
            var parameters = new ShapeParameters();
            parameters.SetParamater(ParameterNames.SideA, 2.1);
            parameters.SetParamater(ParameterNames.SideB, 3.3);
            parameters.SetParamater(ParameterNames.SideC, 1.6);

            var expectedValue = 1.5;

            var shape = shapeFactory.CreateShape(parameters);

            // act
            var result = shape.CalculateSquare();

            // assert
            Assert.AreNotEqual(result, expectedValue);
        }

        [Test]
        public void TriangleIsRectangular_ShouldReturnTrue()
        {
            // arrange
            var parameters = new ShapeParameters();
            parameters.SetParamater(ParameterNames.SideA, 10);
            parameters.SetParamater(ParameterNames.SideB, 24);
            parameters.SetParamater(ParameterNames.SideC, 26);

            var shape = shapeFactory.CreateShape(parameters) as Triangle;

            // act
            var result = shape.IsRectangular;

            // assert
            Assert.IsTrue(result);
        }

        [Test]
        public void TriangleIsRectangular_ShouldReturnFalse()
        {
            // arrange
            var parameters = new ShapeParameters();
            parameters.SetParamater(ParameterNames.SideA, 2.1);
            parameters.SetParamater(ParameterNames.SideB, 3.3);
            parameters.SetParamater(ParameterNames.SideC, 1.6);

            var expectedValue = 1.5;

            var shape = shapeFactory.CreateShape(parameters) as Triangle;

            // act
            var result = shape.IsRectangular;

            // assert
            Assert.IsFalse(result);
        }
    }
}