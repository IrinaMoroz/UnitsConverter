using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitsConverter converter = new UnitsConverter();

            converter.AddConverter(UnitsConverterType.MilligramToGram, ConvertorMethods.ConvertMilligramToGram);
            converter.AddConverter(UnitsConverterType.MilligramToKg, ConvertorMethods.ConvertMilligramToKg);
            converter.AddConverter(UnitsConverterType.MilligramToTonne, ConvertorMethods.ConvertMilligramToTonne);

            converter.Convert(new[] { UnitsConverterType.MilligramToGram, 
                UnitsConverterType.MilligramToKg, 
                UnitsConverterType.MilligramToTonne}, 
                10000000000);
            Console.Read();
        }
    }
}
