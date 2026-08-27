using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime();
            Console.WriteLine(dt1);

            DateTime dt2 = new DateTime(2026,04,14);
            Console.WriteLine(dt2);

            DateTime dt3 = new DateTime(2026, 04, 14,12,15,30);
            Console.WriteLine(dt3);
        }
    }
}
