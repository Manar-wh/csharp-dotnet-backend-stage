using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1: Direct initialization (Size inferred automatically)
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Method 2: Initialization using index numbers
            int[] age = new int[3];
            age[0] = 12;
            age[1] = 4;
            age[2] = 5;

            // Printing elements
            Console.WriteLine($"First element in numbers: {numbers[0]}");
            Console.WriteLine($"Last element in numbers: {numbers[numbers.Length - 1]}");

            Console.WriteLine($"\nAge at index 0: {age[0]}");
            Console.WriteLine($"Age at index 1: {age[1]}");

            Console.ReadKey();
        }
    }
}
