using System;

namespace OrderVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anzahl der Schrauben: ");
            var screws = Int32.Parse(Console.ReadLine());
            Console.Write("Anzahl der Muttern: ");
            var nuts = Int32.Parse(Console.ReadLine());
            Console.Write("Anzahl der Unterlegscheiben: ");
            var washers = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(CheckOrder(screws, nuts) ? "Die Bestellung is okey" : "Kontrollieren Sie Ihre Bestellung!");
            var tottalamount = OrderCalculator(screws, nuts, washers);
            Console.WriteLine("Gesamtbetrag: {0}", tottalamount);
            Console.ReadLine();
        }

        private static double OrderCalculator(double screws, double nuts, double washers)
        {
            return (screws * 5) + (nuts * 3) + (washers * 1);
        }

        private static bool CheckOrder(double screws, double nuts)
        {
            return nuts > screws;
        }
    }
}
