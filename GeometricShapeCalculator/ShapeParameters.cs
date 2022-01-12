using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapeCalculator
{
    public class ShapeParameters
    {
        private IDictionary<string, object> _parameters;

        public ShapeParameters()
        {
            _parameters = new Dictionary<string, object>();
        }

        public void SetParamater(string name, object value)
        {
            _parameters.Add(name, value);
        }

        public double GetParameterValue(string name)
        {
            if (_parameters[name] is double value)
                return value;
            if (_parameters[name] is int intValue)
                return intValue;

            throw new InvalidOperationException($"Parameter {name} is wrong");
        }

        public bool IsContainsParameterName(string name)
        {
            if (_parameters.ContainsKey(name))
                return true;

            return false;
        }
    }
}
