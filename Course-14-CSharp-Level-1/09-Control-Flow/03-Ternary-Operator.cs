using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            bool b = (n % 2 == 0) ? true : false;
            Console.WriteLine($"is {n} even ? {b}");
            Console.ReadKey();
        }
    }
}

