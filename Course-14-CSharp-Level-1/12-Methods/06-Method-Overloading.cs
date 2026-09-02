using System;
using System.Collections.Generic;

namespace CSharp14
{
    class Program
    {
        static int AddNum(int n1, int n2)
        {
            return n1 + n2;
        }

        static int AddNum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        static int AddNum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Sum of 2 numbers (10 + 20) = {AddNum(10, 20)}");
            Console.WriteLine($"Sum of 3 numbers (10 + 20 + 30) = {AddNum(10, 20, 30)}");
            Console.WriteLine($"Sum of 4 numbers (10 + 20 + 30 + 40) = {AddNum(10, 20, 30, 40)}");

            Console.ReadKey();
        }
    }
}
