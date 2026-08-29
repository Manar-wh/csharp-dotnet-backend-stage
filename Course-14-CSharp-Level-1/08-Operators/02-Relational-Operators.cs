using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            Console.WriteLine(" (x > y): " + (x > y));
            Console.WriteLine(" (x < y): " + (x < y));
            Console.WriteLine(" (x == y): " + (x == y));
            Console.WriteLine(" (x >= y): " + (x >= y));
            Console.WriteLine(" (x <= y): " + (x <= y));
            Console.WriteLine(" (x != y): " + (x != y));
            Console.ReadKey();
        }
    }
}

