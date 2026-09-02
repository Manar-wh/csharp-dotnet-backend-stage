using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp14
{
    class Program
    {
        static void PrintInfo(string Name, byte Age, string Country = "Saudi Arabia"){
            Console.WriteLine("Name: {0} \nAge: {1} \nCountry: {2}", Name, Age, Country);
        }
        static void Main(string[] args)
        {
            PrintInfo("Manar", 26);
            Console.ReadKey();
        }
    }
}
