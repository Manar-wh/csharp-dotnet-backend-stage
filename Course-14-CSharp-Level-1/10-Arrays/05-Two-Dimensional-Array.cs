using System;

namespace CSharp14
    {
      class Program
      {
        static void Main(string[] args)
        {
            int[,] Arr = { { 1, 2, 3 }, { 4, 5, 6 } };

            int rows = Arr.GetLength(0);
            int cols = Arr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"[{Arr[i , j]}]");
                }
                Console.WriteLine();
            }
        }
    }
}


