using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp14
{
    class Program

    {
        static void Main(string[] args)
        {
            try
            {
                int[] num = { 1, 2, 3, 4 };
                Console.WriteLine(num[10]);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
