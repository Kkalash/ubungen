using System;

namespace Numbersoutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#Startwert: ");
            Console.Write("#");
            var start = Int32.Parse(Console.ReadLine());
            Console.WriteLine("#Endwert: ");
            Console.Write("#");
            var end = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            while(start <= end)
            {
                Console.WriteLine("#{0}", start);
                start++;
            }

            Console.Read();
        }
    }
}
