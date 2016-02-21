using System.Collections.Generic;

namespace SPMAC_for_Femap.Classes
{
    public static class Sizes
    {
        private static readonly Dictionary<string, double> ListOfSizes = new Dictionary<string, double>();

        public static void Add(string key, double value)
        {
            ListOfSizes.Add(key, value);
        }

        public static double Value(string key)
        {
            return ListOfSizes[key];
        }

        public static void Clear()
        {
            ListOfSizes.Clear();
        }

        public static Dictionary<string, double> Dictonary()
        {
            return ListOfSizes;
        }
    }
}
