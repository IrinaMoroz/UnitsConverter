using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsConverter
{
    public static class ConvertorMethods
    {
        public static double ConvertMilligramToGram(double number)
        {
            return number * 0.001;
        }
        public static double ConvertMilligramToKg(double number)
        {
            return number * 0.000001;
        }
        public static double ConvertMilligramToPound(double number)
        {
            return number * 0.000002204622621849;
        }
        /*
        public static double ConvertMilligramToTonne,
        public static double ConvertGramToMilligram,
        public static double ConvertGramToKg,
        public static double ConvertGramToPound,
        public static double ConvertGramToTonne,
        public static double ConvertKgToMilligram,
        public static double ConvertKgToGram,
        public static double ConvertKgToPound,
        public static double ConvertKgToCentral,
        public static double ConvertKgToTonne,
        public static double ConvertPoundToMilligram,
        public static double ConvertPoundToKg,
        public static double ConvertPoundToGram,
        public static double ConvertPoundToTonne,
        public static double ConvertTonneToMilligram,
        public static double ConvertTonneToGram,
        public static double ConvertTonneTokg,
        public static double ConvertTonneToPound*/
    }
}
