using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };

            // Access elements individually by index
            Console.WriteLine("Element in first index : " + numbers[0]);
            Console.WriteLine("Element in second index : " + numbers[1]);
            Console.WriteLine("Element in third index : " + numbers[2]);

            // Access elements dynamically using a for loop
            Console.WriteLine("\nAccess array using loop:\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element in index {0} : {1}", i, numbers[i]);
            }

            Console.ReadKey();
        }
    }
}
