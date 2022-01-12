using GeometricShapeCalculator.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapeCalculator
{
    public class ShapeFactory
    {
        public Shape CreateShape(ShapeParameters parameters)
        {
            Shape shape;
            
            switch (DetermineShapeTypeName(parameters))
            {
                case nameof(Circle):
                    shape = new Circle(parameters);
                    break;
                case nameof(Triangle):
                    shape = new Triangle(parameters);
                    break;
                default:
                    throw new Exception("Shape is not found");
            }

            return shape;
        }

        private string DetermineShapeTypeName(ShapeParameters parameters)
        {
            if (parameters.IsContainsParameterName(ParameterNames.Radius))
            {
                return typeof(Circle).Name;
            }
            
            if (parameters.IsContainsParameterName(ParameterNames.SideA)
                && parameters.IsContainsParameterName(ParameterNames.SideB)
                && parameters.IsContainsParameterName(ParameterNames.SideC))
            {
                return typeof(Triangle).Name;
            }

            return null;
        }
    }
}
