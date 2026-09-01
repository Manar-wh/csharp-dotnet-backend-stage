using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 51, 1, 3, 4, 98, 2, 85, 0 };

            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }

            int countNum = numbers.Count();
            int minNum = numbers.Min();
            int maxNum = numbers.Max();
            int sumNum = numbers.Sum();
            double avgNum = numbers.Average();

            Console.WriteLine($"\n\nCount of Elements : {countNum}");
            Console.WriteLine($"Smallest Element  : {minNum}");
            Console.WriteLine($"Largest Element   : {maxNum}");
            Console.WriteLine($"Sum of Elements   : {sumNum}");
            Console.WriteLine($"Average           : {avgNum}");

            Console.ReadKey();
        }
    }
}
