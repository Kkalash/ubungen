using System;
using System.Collections.Generic;

namespace GuessNumber
{
    class Program
    {
        private static Random rand = new Random();
        static void Main(string[] args)
        {
            Console.Write("Bitte die Untergreaze weahlen: ");
            var minValue = Int32.Parse(Console.ReadLine());
            Console.Write("Bitte die Obergreaze weahlen: ");
            var maxValue = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Bitte erraten Sie die gesuchte Zahl, sie befindet sich zwischen {0} und {1}.\n", minValue, maxValue);

            var guessNumbers = new List<int>();
            var secretNumber = rand.Next(minValue, maxValue + 1);
            var input = 0;
            var attempt = 1;
            while (input != secretNumber)
            {
                Console.Write("Ihr {0}. Versuch: ", attempt.ToString("D2"));
                var isNum = Int32.TryParse(Console.ReadLine(), out input);
                if (isNum)
                {
                    if (input == secretNumber)
                    {
                        Console.WriteLine("Glueckwuansch die von Ihnen eingegeben Zahl ( {0} ) stimmt mit der gesuchten Zahl Ueberein.", input);
                        break;
                    }

                    if (input >= minValue && input <= maxValue)
                    {
                        if (guessNumbers.Contains(input))
                        {
                            Console.WriteLine("Mit dieser Zahl haben Sie es schon einmal versucht!\n");
                        }
                        else
                        {
                            Console.WriteLine(input < secretNumber ? "Die gesuchte Zahl ist Gruesser!\n" : "Die gesuchte Zahl ist Kleiner!\n");
                            guessNumbers.Add(input);
                        }
                    }

                    else
                    {
                        Console.WriteLine("Die eingegebene Zahl befindet sich ausserhalb des von ihnen definierten Bereich.\n");
                    }
                }

                else
                {
                    Console.WriteLine("Bitte nur Z A H L E N eingeben.\n");
                }

                attempt++;
            }
            Console.ReadLine();
        }
    }
}
