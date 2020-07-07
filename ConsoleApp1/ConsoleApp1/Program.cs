using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = test.CreateThreeDimensional();
            var min = test.FindMiniNumber(arr);
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write("(");
                    for (int z = 0; z < 4; z++)
                    {
                        Console.Write(" " + arr[x, y, z] + " ");
                    }
                    Console.Write(")");
                }
                Console.WriteLine();
            }
            Console.Write(min);
        }

    }
    class test
    {
        public static int[,,] CreateThreeDimensional()
        {
            var rand = new Random();
            int[,,] threeDimen = new int[6, 3, 4];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        threeDimen[i, j, k] = rand.Next(1, 100);
                    }
                }
            }
            return threeDimen;
        }
        public static int FindMiniNumber(int[,,] threeDimenArray)
        {
            int min = Int32.MaxValue;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        min = threeDimenArray[i, j, k] < min ? threeDimenArray[i, j, k] : min;
                    }
                }
            }
            return min;
        }
    }
}
