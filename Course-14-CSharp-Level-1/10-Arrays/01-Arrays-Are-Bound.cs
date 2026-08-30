using System;

namespace CSharp14
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Create an array with 3 elements (indices 0, 1, 2)
                int[] numbers = { 1, 2, 3 };

                numbers[0] = 1;
                numbers[1] = 2;
                numbers[2] = 3;

                // The following line will throw System.IndexOutOfRangeException:
                //numbers[3] = 4;

                Console.WriteLine($"First element: {numbers[0]}");
                Console.WriteLine($"Array Length: {numbers.Length}");

                Console.ReadKey();
            }
        }
}


