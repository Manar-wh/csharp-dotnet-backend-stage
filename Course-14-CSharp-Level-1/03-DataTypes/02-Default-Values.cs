using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = default;
            double price = default;
            bool isActive = default;
            char letter = default;
            string name = default;

            Console.WriteLine(number);    // 0
            Console.WriteLine(price);     // 0
            Console.WriteLine(isActive);  // False
            Console.WriteLine(letter);    // '\0'
            Console.WriteLine(name);      // null
            Console.ReadKey();

        }
    }
}
