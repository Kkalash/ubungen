using System;
using System.Text;

namespace SequenceOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "112";
            var count = 1;
            Console.WriteLine("{0}. Folge: {1}", count, text);
            while (count <= 15)
            {
                text = NextRound(text);
                Console.WriteLine("{0}. Folge: {1}", count, text);
                count++;
            }
        }

        private static string NextRound(string text)
        {
            int length;
            var result = new StringBuilder();
            while ((length = text.Length) > 0)
            {
                var letter = text[0];
                var lengthNew = (text = text.TrimStart(letter)).Length;
                result.Append((length - lengthNew).ToString() + letter);
            }
            return result.ToString();
        }
    }
}
