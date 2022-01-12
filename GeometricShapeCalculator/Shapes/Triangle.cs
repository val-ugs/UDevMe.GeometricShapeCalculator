using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapeCalculator.Shapes
{
    public class Triangle : Shape
    {
        double _sideA;
        double _sideB;
        double _sideC;

        public Triangle(ShapeParameters parameters) : base(parameters)
        {
            _sideA = parameters.GetParameterValue(ParameterNames.SideA);
            _sideB = parameters.GetParameterValue(ParameterNames.SideB);
            _sideC = parameters.GetParameterValue(ParameterNames.SideC);
        }

        public bool IsRectangular
        {
            get
            {
                if (IsPythagorean(_sideA , _sideB , _sideC)
                    || IsPythagorean(_sideB, _sideC, _sideA)
                    || IsPythagorean(_sideC, _sideA, _sideB))
                {
                    return true;
                }
                return false;
            }
        }

        private bool IsPythagorean(double a, double b, double c)
        {
            return a * a + b * b == c * c;
        }

        public override double CalculateSquare()
        {
            double p = (_sideA + _sideB + _sideC) / 2;

            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }
    }
}
