using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name?  ");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter your age?");
            int Age =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Name);

            Console.ReadKey();
        }
    }
}

