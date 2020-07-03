using System;
using System.Linq;

namespace SMA
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] fields = { 12.8, 65.9, 45.32, 77.25, 105.32 };
            var result = AverageOfValues(fields);
            Console.WriteLine(result);
        }

        private static double AverageOfValues(double[] fields)
        {
            var sum = fields.Sum();
            var result = sum / fields.Length;
            return result;
        }
    }
}
