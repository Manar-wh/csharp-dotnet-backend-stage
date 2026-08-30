using System;

namespace CSharp14
    {
        class Program
        {
            static void Main(string[] args)
            {
            Console.WriteLine("Enter number of students: ");
            int Num = int.Parse(Console.ReadLine());

            int[] grades = new int[Num];

            for (int i = 0; i < Num; i++)
            {
                Console.Write($"Enter grade for student {i + 1}: ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < Num; i++)
            {
                Console.WriteLine($"Student {i+1} grade's : {grades[i]} ");
            }
                Console.ReadKey();
            }
        }
}


