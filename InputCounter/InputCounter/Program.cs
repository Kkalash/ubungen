using System;

namespace InputCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben SIe ein Wort ein: ");
            var wort = Console.ReadLine();
            Console.WriteLine();

            var count = 1;
            while(count <= wort.Length)
            {
                Console.WriteLine("{0}. {1}",count, wort);
                count++;
            }
        }
    }
}
