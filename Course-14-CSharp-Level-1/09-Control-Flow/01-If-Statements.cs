using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 15;

            // Single if statement
            if (num > 0)
            {
                Console.WriteLine($"{num} is Positive");
            }

            // if...else statement
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} It's even number");
            }
            else
            {
                Console.WriteLine($"{num} It's odd number");
            }

            // if...else if...else statement

            int mark = 90;

            if (mark >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (mark >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (mark >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            Console.ReadKey();
            
        }
    }
}

