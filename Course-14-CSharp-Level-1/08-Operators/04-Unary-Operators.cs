using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10, result;
            bool flag = false;
            result = +num;
            Console.WriteLine("+num = " + (result));

            result = -num;
            Console.WriteLine("-num = " + (result));

            result = ++num;
            Console.WriteLine("++num = " + (result));

            result = --num;
            Console.WriteLine("--num = " + (result));

            Console.WriteLine("!flag = " + (!flag));

            // Postfix Increment: Prints 10 then increments to 11
            Console.WriteLine(num++);
            Console.WriteLine(num);

            // Prefix Increment: Increments to 12 then prints 12
            Console.WriteLine(++num);
            Console.WriteLine(num);
            Console.ReadKey();

        }
    }
}

