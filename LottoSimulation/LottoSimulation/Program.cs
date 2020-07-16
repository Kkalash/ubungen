using System;
using System.Collections.Generic;
using System.Linq;

namespace LottoSimulation
{
    class Program
    {
        public static Random rand = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("***Lotto Simulation***");
            var listOfInputNum = InputNumbers();
            var lottoNums = StartLotto(listOfInputNum);
            Console.WriteLine("Lotto Zahlen: ");
            foreach (var num in lottoNums)
            {
                Console.WriteLine(num);
            }
            Console.Read();
        }

        private static List<string> StartLotto(IEnumerable<int> inputList)
        {
            var lottoNums = new List<string>();
            var randNums = new List<int>();
            var count = 0;
            while (lottoNums.Count() != inputList.Count())
            {
                var nextNum = rand.Next(1, 50);
                if (inputList.Contains(nextNum) && !randNums.Contains(nextNum))
                {
                    lottoNums.Add(nextNum.ToString() + " (" + count + " Spielen)");
                }
                count++;
            }
            return lottoNums;
        }

        private static List<int> InputNumbers()
        {
            var listOfNum = new List<int>();
            var count = 1;
            Console.WriteLine("Geben Sie 6 Zahlen ein mit Leerzeichen zwischen die Zahlen(Zwischen 1-49)");
            while (count <= 6)
            {
                Console.Write("{0}. ", count);
                var input = Console.ReadLine();
                int inputNum = Int32.Parse(input);

                if (CheckNum(inputNum) && !listOfNum.Contains(inputNum))
                {
                    listOfNum.Add(inputNum);
                    count++;
                }
                else
                {
                    Console.WriteLine("Die Zahl darf nicht zwei mal vorgommen!");
                    Console.WriteLine("Die Zahl soll zwischen 1 und 49 sein!");
                }
            }

            return listOfNum;
        }

        private static bool CheckNum(int num)
        {
            return num >= 1 && num <= 49;
        }
    }
}
