using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Basic For Loop ---");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n-----------------------------\n");

            Console.WriteLine("--- Nested For Loop (Grid 1-3) ---");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i}][{j}]  ");

                }
                Console.WriteLine();
            }
        }
    }
}

