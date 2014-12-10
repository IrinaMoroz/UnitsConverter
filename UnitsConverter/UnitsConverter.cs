using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsConverter
{
    public class UnitsConverter
    {
        public delegate double Function(double num);
        private Dictionary<UnitsConverterType, Function> converters;

        public UnitsConverter()
        {
            converters = new Dictionary<UnitsConverterType,Function>();
        }
        public void AddConverter(UnitsConverterType ut, Function func)
        {
            if (converters.ContainsKey(ut))
                throw new ArgumentException(String.Format("{0} is already registred", ut));
            converters.Add(ut, func);
        }

        public double Convert(UnitsConverterType[] direction, double inputValue)
        {
            double result = inputValue;
            foreach (var unitType in direction)
            {
                if (converters.ContainsKey(unitType))
                    result = converters[unitType](result);
                else
                    throw new ArgumentException(String.Format("{0} hasn't been registered yet. Use AddConverter method to registering new Converter", unitType));
            }
                
            return result;
        }
           


    }
}
