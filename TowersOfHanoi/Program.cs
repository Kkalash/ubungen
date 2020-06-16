using System;
using System.Collections;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            TowerOfHanoi T = new TowerOfHanoi();
            Console.Write("Enter the number of discs: ");
            string cnumdiscs = Console.ReadLine();
            TowerOfHanoi.numdiscs = Convert.ToInt32(cnumdiscs);
            T.initializeTowers();
            T.ReadInpuAndStart();
        }
    }

    class TowerOfHanoi
    {
        private static Stack[] towers = new Stack[3];
        private static Stack tmpStack = new Stack();

        public static int numdiscs { get; set; }

        public void initializeTowers()
        {
            for (int i = 0; i < towers.Length; i++)
            {
                towers[i] = new Stack();
            }
            for (int i = numdiscs; i >= 1; i--)
            {
                towers[0].Push(i);
                tmpStack.Push(i);
            }
        }

        private void MoveTower(int disc, int moveForm, int moveTo, int other)
        {
            if (disc > 0)
            {
                //MoveTower(disc - 1, from, other, to);
                MoveVisual(disc, moveForm, moveTo);
                //MoveTower(disc - 1, other, to, from);
            }
        }

        private void MoveVisual(int disc, int fromDisc, int target)
        {
            var moveAvailable = false;
            var element = new object();
            if (DiscExists(fromDisc, disc))
            {
                element = towers[fromDisc - 1].Pop();
                moveAvailable = true;
            }

            moveAvailable = moveAvailable != false ? IsTopDiscBigger(target, disc) : false;
            if (moveAvailable)
            {
                towers[target - 1].Push(element);
            }

            Log(disc, fromDisc, target, moveAvailable);
        }

        private bool DiscExists(int stack, int value)
        {

            return Convert.ToInt32(towers[stack - 1].Peek()) == value;
        }

        private bool IsTopDiscBigger(int stack, int disc)
        {
            var topDisk = towers[stack - 1].Count != 0 ? Convert.ToInt32(towers[stack - 1].Peek()) : disc + 1;
            return towers[stack - 1] != null && topDisk > disc;
        }

        public void Log(int disc, int from, int to, bool stackMoved)
        {
            var status = !stackMoved ? "Can't move" : "Move";
            Console.WriteLine(status + " disc {0} from tower {1} to tower {2}", disc, from, to);
        }

        public void WriteStackInConsoleAfterProcessing()
        {
            for (int discs = 0; discs < towers.Length; discs++)
            {
                foreach (var disc in towers[discs])
                {
                    Console.Write(disc);
                }
                Console.WriteLine();
            }
        }
        public void ReadInpuAndStart()
        {
            do
            {
                Console.Write("disc: ");
                var disc = Console.ReadLine();
                var numDisc = Convert.ToInt32(disc);

                Console.Write("Move disc from: ");
                var discFrom = Console.ReadLine();
                var moveFrom = Convert.ToInt32(discFrom);

                Console.Write("Move disc to: ");
                var discTo = Console.ReadLine();
                var moveTo = Convert.ToInt32(discTo);

                MoveTower(numDisc, moveFrom, moveTo, 3);
                WriteStackInConsoleAfterProcessing();

                if (IsSameStack(towers[2], tmpStack))
                {
                    Console.WriteLine("***Game Over***");
                }
            } while (!IsSameStack(towers[2], tmpStack));
        }

        private bool IsSameStack(Stack stack1, Stack stack2)
        {
            bool flag = true;

            if (stack1.Count != stack2.Count)
            {
                flag = false;
                return flag;
            }
            while (stack1.Count != 0)
            {
                var peek1 = Convert.ToInt32(stack1.Peek());
                var peek2 = Convert.ToInt32(stack2.Peek());
                if (peek1 == peek2)
                {
                    stack1.Pop();
                    stack2.Pop();
                }
                else
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
    }
}
