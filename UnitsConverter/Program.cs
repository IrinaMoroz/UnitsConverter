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

            converter.Convert(new []{UnitsConverterType.MilligramToGram, UnitsConverterType.MilligramToKg}, 1000);
            Console.Read();
        }
    }
}
