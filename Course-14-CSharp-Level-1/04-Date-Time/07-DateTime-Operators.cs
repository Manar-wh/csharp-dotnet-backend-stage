using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2022,2,22);
            DateTime dt2 = new DateTime(2024,2,22);
            TimeSpan ts = new TimeSpan(5, 3, 5, 44);
            Console .WriteLine(dt1 + ts);
            Console.WriteLine(dt2 - dt1);
            Console.WriteLine(dt1 == dt2);
            Console.WriteLine(dt1 != dt2);
            Console.WriteLine(dt1 > dt2);
            Console.WriteLine(dt1 < dt2);

            Console.ReadKey();
        }
    }
}

