using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 5;
            Console.WriteLine(" ~x     : " + (~x));
            Console.WriteLine("(x & y) : " + (x & y));
            Console.WriteLine("(x | y) : " + (x | y));
            Console.WriteLine("(x ^ y) : " + (x ^ y));
            Console.WriteLine("(x << 1): " + (x << 1));
            Console.WriteLine("(x >> 1): " + (x >> 1));
            Console.ReadKey();
            
        }
    }
}

