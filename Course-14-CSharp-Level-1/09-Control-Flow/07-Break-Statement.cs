using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Reached 5, breaking the loop!");
                    break;
                }
                Console.WriteLine($"i = {i}");
            }
            Console.ReadKey();
        }
    }
    
}

