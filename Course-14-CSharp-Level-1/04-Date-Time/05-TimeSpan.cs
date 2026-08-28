using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan TS = new TimeSpan(55, 35, 53);
            Console.WriteLine(TS);
            Console.WriteLine(TS.Days);
            Console.WriteLine(TS.Hours);
            Console.WriteLine(TS.Minutes);
            Console.WriteLine(TS.Seconds);

            //this will add time span to the date.
            DateTime DT = new DateTime(2026, 8, 28);
            DateTime newDT = DT.Add(TS);
            Console.WriteLine(newDT);

            Console.ReadKey();
        }
    }
}

