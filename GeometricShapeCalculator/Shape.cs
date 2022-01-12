using System;
using System.Collections.Generic;

namespace GeometricShapeCalculator
{
    public abstract class Shape
    {
        public Shape(ShapeParameters parameters) { }
        public abstract double CalculateSquare();
    }
}
