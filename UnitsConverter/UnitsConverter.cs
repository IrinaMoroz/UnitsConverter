﻿using System;
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
            converters.Add(ut, func);
        }

        public double Convert(UnitsConverterType[] direction, double inputValue)
        {
            double result = inputValue;
            foreach (var unitType in direction)
                result = converters[unitType](result);
            return result;
        }
           


    }
}
