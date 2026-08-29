using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine("a && b : " + (a && b));
            Console.WriteLine("a || b : " + (a || b));
            Console.WriteLine("!a     : " + (!a));
            Console.WriteLine("!b     : " + (!b));
            Console.ReadKey();
        }
    }
}

