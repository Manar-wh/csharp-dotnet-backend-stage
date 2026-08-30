using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("Iteration {0}", i);
                i++;
            }

            Console.ReadKey();
        }
    }
}

