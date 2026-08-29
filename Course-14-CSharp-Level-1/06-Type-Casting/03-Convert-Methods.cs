using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int myint = 2;
            double mydouble = 33.2;
            bool myBool = true;
            Console.WriteLine(Convert.ToDouble(myint));
            Console.WriteLine(Convert.ToString(myint));
            Console.WriteLine(Convert.ToInt32(mydouble));
            Console.WriteLine(Convert.ToString(myBool));
            Console.ReadKey();
        }
    }
}

