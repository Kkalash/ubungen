using System;

namespace MultiplicationWithoutMultiplying
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNum1;
            bool isNum2;
            do
            {
                Console.Write("Multiplikad: ");
                var num1 = Console.ReadLine();
                Console.Write("Multiplikator: ");
                var num2 = Console.ReadLine();

                isNum1 = Int32.TryParse(num1, out int multiplikand);
                isNum2 = Int32.TryParse(num2, out int multiplikator);
                if (isNum1 && isNum2)
                {
                    var result = Addition(multiplikator, multiplikand);
                    Console.Write(String.Format("Das Ergebnis der Multiplikation is: {0} ", result));
                    isNum1 = true;
                    isNum2 = true;
                }
                else
                {
                    Console.WriteLine("Bitte gaben Sie ein richtige Zahl ein!");
                }

            } while (!isNum1 || !isNum2);
        }

        public static int Addition(int multiplikator, int multiplikand)
        {
            var result = 0;
            while (multiplikator > 0)
            {
                result += multiplikand;
                multiplikator--;
            }
            return result;
        }
    }
}
