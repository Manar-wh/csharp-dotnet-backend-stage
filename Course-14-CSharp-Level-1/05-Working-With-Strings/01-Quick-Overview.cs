using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Manar Alwahedi";
            Console.WriteLine(s1.Length);
            Console.WriteLine(s1.Substring(2,8));
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());
            Console.WriteLine(s1[0]);
            Console.WriteLine(s1.Insert(5, "ggggg"));
            Console.WriteLine(s1.Replace("a", "*"));
            Console.WriteLine(s1.IndexOf("i"));
            Console.WriteLine(s1.Contains("a"));
            Console.WriteLine(s1.Contains("x"));
            Console.WriteLine(s1.LastIndexOf("a"));

            string s2 = "Ahmed,Ali,omar";
            string[] NamesList = s2.Split(',');
            Console.WriteLine(NamesList[0]); 
            Console.WriteLine(NamesList[1]); 
            Console.WriteLine(NamesList[2]);

            string s3 = " Manar Alwahedi ";
            Console.WriteLine(s3.Trim());

        }
    }
}

