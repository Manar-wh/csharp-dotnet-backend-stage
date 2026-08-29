using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("Addition (x + y): " + (x + y));
            Console.WriteLine("Subtraction (x - y): " + (x - y));
            Console.WriteLine("Multiplication (x * y): " + (x * y));
            Console.WriteLine("Integer Division (x / y): " + (x / y));
            Console.WriteLine("Double Division ((double)x / y): " + ((double)x / y));
            Console.WriteLine("Modulus (x % y): " + (x % y));
            Console.ReadKey();
        }
    }
}

