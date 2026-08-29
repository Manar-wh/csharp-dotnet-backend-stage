using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            string resulte;

            resulte = (x % 2) == 0 ? "Even Number" : "Odd Number";
            Console.WriteLine($"{x} is {resulte} ");
            Console.ReadKey();
        }
    }
}

