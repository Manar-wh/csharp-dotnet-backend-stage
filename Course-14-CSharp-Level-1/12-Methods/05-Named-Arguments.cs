using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp14
{
    class Program

    {
        static void PrintChildInfo(string Chield1 , string Chield2, string Chield3)
        {
            Console.WriteLine($"The Youngest Child is: {Chield3}");
        }
        static void Main(string[] args)
        {
            PrintChildInfo(Chield3: "Moha", Chield1: "Sarah", Chield2: "Rayan");
            Console.ReadKey();
        }
    }
}
