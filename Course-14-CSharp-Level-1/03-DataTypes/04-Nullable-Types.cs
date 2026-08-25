using System;

namespace CSharp14
{
    class Program
    {

        static void Main(string[] args)
        {
            // Nullable<T> syntax
            Nullable<int> number1 = null;

            // Shorthand syntax using ?
            int? number2 = null;

            Console.WriteLine("Number 1: " + number1);
            Console.WriteLine("Number 2: " + number2);

            number1 = 10;
            number2 = 20;

            Console.WriteLine("Number 1 after assigning a value: " + number1);
            Console.WriteLine("Number 2 after assigning a value: " + number2);

            Console.ReadKey();

        }
    }
}
