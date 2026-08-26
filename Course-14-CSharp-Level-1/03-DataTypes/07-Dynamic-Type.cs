using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {

            dynamic Mydynamic = 10;
            Console.WriteLine("Mydynamic: {0}, {1}", Mydynamic, Mydynamic.GetType());
            Mydynamic = "Manar";
            Mydynamic = Mydynamic.ToUpper();
            Console.WriteLine("Mydynamic: {0}, {1}", Mydynamic, Mydynamic.GetType());
            Mydynamic = true;
            Console.WriteLine("Mydynamic: {0}, {1}", Mydynamic, Mydynamic.GetType());

            Console.ReadKey();
        }
    }
}
