using System;

namespace Centrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie die Cent ein: ");
            var tottalCent = Int32.Parse(Console.ReadLine());
            var dollar = Dollar(tottalCent);
            var cent = Cent(tottalCent);
            Console.Write("Das ergibt {0} Dollar und {1} Cent", dollar, cent);
            Console.Read();
        }

        public static int Dollar(int cent)
        {
            return cent / 100;
        }

        private static int Cent(int cent)
        {
            return cent % 100;
        }
    }
}
