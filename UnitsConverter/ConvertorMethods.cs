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
        public static double ConvertMilligramToTonne(double number)
        {
            return number * 1E-9d;
        }
        public static double ConvertGramToMilligram(double number)
        {
            return number * 1000;
        }
        public static double ConvertGramToKg(double number)
        {
            return number * 0.001;
        }
        public static double ConvertGramToPound(double number)
        {
            return number * 0.002204622621849;
        }
        public static double ConvertGramToTonne(double number)
        {
            return number * 0.000001;
        }
        public static double ConvertKgToMilligram(double number)
        {
            return number * 1000000;
        }
        public static double ConvertKgToPound(double number)
        {
            return number * 2.204622621849;
        }
        public static double ConvertKgToTonne(double number)
        {
            return number * 0.001;
        }
        public static double ConvertPoundToMilligram(double number)
        {
            return number * 453592.37;
        }
        public static double ConvertPoundToGram(double number)
        {
            return number * 453.59237;
        }
        public static double ConvertPoundToKg(double number)
        {
            return number * 0.45359237;
        }
        public static double ConvertPoundToTonne(double number)
        {
            return number * 0.00045359237;
        }
        public static double ConvertTonneToMilligram(double number)
        {
            return number * 1000000000;
        }
        public static double ConvertTonneToGram(double number)
        {
            return number * 1000000;
        }
        public static double ConvertTonneTokg(double number)
        {
            return number * 1000;
        }
        public static double ConvertTonneToPound(double number)
        {
            return number * 2204.622621849;
        }
    }
}
