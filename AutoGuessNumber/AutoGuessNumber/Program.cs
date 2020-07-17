using System;
using System.Collections.Generic;

namespace AutoGuessNumber
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

            Console.WriteLine("Bitte geben nach jedem Versuch R,G oder K an. ja nachdem ob \n" +
                "R die Zahl richtig ist \n" +
                "G die gesuchte Zahl gruesser ist \n" +
                "K die gesuchte Zahl kleiner ist \n");

            var rating = rand.Next(minValue, maxValue + 1);
            var attempt = 0;
            string input;
            do
            {
                attempt++;
                Console.WriteLine("{0}. Versuch: {1}", attempt, rating);
                input = Console.ReadLine();

                if (input == "G" || input == "g")
                {
                    minValue = rating;
                    rating = NumbersGenerator(rating, minValue, maxValue);
                }
                if (input == "K" || input == "k")
                {
                    maxValue = rating;
                    rating = NumbersGenerator(rating, minValue, maxValue);
                }

                if (input == "R" || input == "r")
                {
                    Console.WriteLine("Die gesuchte Zahl war also die {0}!", rating);
                }

            } while (input != "R" && input != "r");

            Console.ReadLine();
        }

        private static List<int> numbers = new List<int>();
        private static int NumbersGenerator(int rating, int minValue, int maxValue)
        {
            numbers.Add(rating);
            do
            {
                rating = rand.Next(minValue, maxValue + 1);
            } while (numbers.Contains(rating));
            return rating;
        }
    }
}
