using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Useful Escape Characters:\n");

            // NewLine
            Console.WriteLine("Newline:");
            Console.WriteLine("Welcome to \n ProgrammingAvices\n");

            // Tab
            Console.WriteLine("Tab:");
            Console.WriteLine("Welcome to\tProgrammingAvices\n");

            // Backspace
            Console.WriteLine("Backspace:");
            Console.WriteLine("Welcome to \bProgrammingAvices\n");

            // Single quote
            Console.WriteLine("Single Quote:");
            Console.WriteLine("Welcome to \' ProgrammingAvices\n");

            // Double quote
            Console.WriteLine("Double Quote:");
            Console.WriteLine("Welcome to \" ProgrammingAvices\n");

            // Backslash
            Console.WriteLine("Backslash:");
            Console.WriteLine("Welcome to \\ ProgrammingAvices\n");

            // Alert
            Console.WriteLine("Alert:");
            Console.WriteLine("\a");

            Console.ReadKey();
        }
    }
}
