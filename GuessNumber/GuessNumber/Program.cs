using System;

namespace GuessNumber
{
    class Program
    {
        private static Random rand = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte erraten Sie die gesuchte Zahl, sie befindet sich zwischen 1 und 100.");

            var secretNumber = rand.Next(1, 101);
            var input = 0;
            var attempt = 1;
            while (input != secretNumber)
            {
                input = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ihr {0}. Versuch: {1}", attempt, input);
                Console.WriteLine(input < secretNumber ? "Die gesuchte Zahl ist Gruesser!" : "Die gesuchte Zahl ist Kleiner!");
                if (input == secretNumber)
                    Console.WriteLine("Glueckwuensch die von Ihnen eingegeben Zahl ( {0} ) stimmt mit der gesuchten Zahl Üeberein.", input);
                attempt++;
            }

            Console.ReadLine();
        }
    }
}
