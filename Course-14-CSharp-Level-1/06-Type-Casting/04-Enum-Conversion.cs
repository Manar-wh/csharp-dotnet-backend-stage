using System;

namespace CSharp14
{
    class Program
    {
        enum WeekDays
        {
            Monday=1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Friday);
            Console.WriteLine((WeekDays)3);

            Console.ReadKey();
        }
    }
}

