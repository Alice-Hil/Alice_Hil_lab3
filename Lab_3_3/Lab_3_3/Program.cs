using System;
using System.Linq;

namespace Lab_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 4;
            string[] arr = { "AA", "ABA", "B", "AAA", "BBB", "CCCC"};
            var str = arr.OrderBy(n => n).FirstOrDefault(s => s.Length == value);
            Console.WriteLine($"Answer: {str}");
        }
    }
}
