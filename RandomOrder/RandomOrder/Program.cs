using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomOrder
{
    class Program
    {
        public static Random rand = new Random();
        static void Main(string[] args)
        {
            var sortedList = new List<int>() {1, 2, 3, 4, 5, 6 };
            var randomList = RandomOrder(sortedList);
            Console.WriteLine(String.Join(",", sortedList));
            Console.WriteLine(String.Join(",", randomList));
        }

        private static IList<T> RandomOrder<T>(IList<T> sortedList)
        {
            //IList<T> randomList = sortedList;
            //int n = sortedList.Count();
            //while(n > 0)
            //{
            //    n--;
            //    int randNum = rand.Next(n);
            //    var value = sortedList[randNum];
            //    sortedList[randNum] = sortedList[n];
            //    sortedList[n] = value;
            //}

            var randomList = sortedList.OrderBy(a => rand.Next()).ToList();
            return randomList;
        }
    }
}
