using GeometricShapeCalculator.Shapes;
using NUnit.Framework;

namespace GeometricShapeCalculator.Tests
{
    public class CircleTests
    {
        private ShapeFactory shapeFactory;

        [SetUp]
        public void Setup()
        {
            shapeFactory = new ShapeFactory();
        }

        [Test]
        public void CircleCalculateSquare_ShouldReturnTrue()
        {
            // arrange
            var parameters = new ShapeParameters();
            parameters.SetParamater(ParameterNames.Radius, 3.2);

            var expectedValue = 32.169908772759484;

            var shape = shapeFactory.CreateShape(parameters);

            // act
            var result = shape.CalculateSquare();

            // assert
            Assert.AreEqual(result, expectedValue);
        }

        [Test]
        public void CircleCalculateSquare_ShouldReturnFalse()
        {
            // arrange
            var parameters = new ShapeParameters();
            parameters.SetParamater(ParameterNames.Radius, 3.2);

            var expectedValue = 30;

            var shape = shapeFactory.CreateShape(parameters);

            // act
            var result = shape.CalculateSquare();

            // assert
            Assert.AreNotEqual(result, expectedValue);
        }
    }
}