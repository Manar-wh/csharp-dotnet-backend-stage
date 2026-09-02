using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp14
{
    class Program
    {
        static void PrintInfo(string Name, byte Age){
            Console.WriteLine($"Name: {Name} \nAge: {Age}");
        }
        static void Main(string[] args)
        {
            PrintInfo("Manar", 26);
            Console.ReadKey();
        }
    }
}
