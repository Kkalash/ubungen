using System;

namespace Rabattaktion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie den Gesamtenbetrag ein: ");
            int tottalAmount = Int32.Parse(Console.ReadLine());
            var discountamount = DiscountCalculator(tottalAmount);
            Console.WriteLine("Discountpreis: {0}", discountamount);
        }

        private static double DiscountCalculator(int amount)
        {
            var discountamount = amount >= 1000 ? Convert.ToDouble(amount) * 0.10 : 0;
            var tottalAmountAfterDiscount = amount - discountamount;

            return tottalAmountAfterDiscount;
        }
    }
}
