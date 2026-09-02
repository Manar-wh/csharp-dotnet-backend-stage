using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp14
{
    class Program
    {
        static int AddNumbers(int x, int y){
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AddNumbers(4,4));
            Console.ReadKey();
        }
    }
}
