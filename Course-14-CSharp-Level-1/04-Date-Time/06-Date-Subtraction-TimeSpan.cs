using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2022,2,22);
            DateTime dt2 = new DateTime(2024,2,22);
            TimeSpan ts = dt2.Subtract(dt1);
            Console.WriteLine(ts.Days);
            Console.ReadKey();
        }
    }
}

