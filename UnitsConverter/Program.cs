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

            converter.AddConverter(UnitsConverterType.GramToKg, ConvertorMethods.ConvertGramToKg);
            converter.AddConverter(UnitsConverterType.KgToMilligram, ConvertorMethods.ConvertKgToMilligram);
            converter.AddConverter(UnitsConverterType.MilligramToTonne, ConvertorMethods.ConvertMilligramToTonne);

            double result = converter.Convert(new[] { UnitsConverterType.GramToKg, 
                UnitsConverterType.KgToMilligram, 
                UnitsConverterType.MilligramToTonne}, 
                1000);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
