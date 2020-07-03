using System;

namespace InputIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Number: ");
                string num = Console.ReadLine();
                try
                {
                    var number = Convert.ToInt32(num);
                    Console.WriteLine(number + " is an Integer number");
                    break;
                } catch
                {
                    Console.WriteLine(num + "is not an integer number.");
                }
            }
        }
    }
}
