using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp14
{
    class Program

    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Random numbers between 10 and 19:");

            for (int i = 0; i < 5; i++)
            {
                int RandomNum = rnd.Next(10, 20);
                Console.WriteLine(RandomNum);
            }
            Console.ReadKey();
        }
    }
}
