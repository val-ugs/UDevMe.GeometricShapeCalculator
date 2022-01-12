using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapeCalculator.Shapes
{
    public class Circle : Shape
    {
        double _radius;

        public Circle(ShapeParameters parameters) : base(parameters)
        {
            _radius = parameters.GetParameterValue(ParameterNames.Radius);
        }

        public override double CalculateSquare()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
