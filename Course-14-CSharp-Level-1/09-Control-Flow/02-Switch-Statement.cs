using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Switch with grouped cases (Vowel check)
            Console.Write("Enter a letter: ");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine($"{ch} is a Vowel");
                    break;

                default:
                    Console.WriteLine($"{ch} is Not a vowel");
                    break;
            }

            Console.WriteLine("-----------------------------");

            // Example 2: Simple Calculator
            Console.Write("Enter first number: ");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"{first} + {second} = {first + second}");
                    break;

                case '-':
                    Console.WriteLine($"{first} - {second} = {first - second}");
                    break;

                case '*':
                    Console.WriteLine($"{first} * {second} = {first * second}");
                    break;

                case '/':
                    if (second != 0)
                        Console.WriteLine($"{first} / {second} = {first / second}");
                    else
                        Console.WriteLine("Cannot divide by zero!");
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }

            Console.WriteLine("-----------------------------");

            // Example 3: Comparing Strings
            string name = "Mohammed";

            switch (name.ToLower())
            {
                case "mohammed":
                    Console.WriteLine("Yes, Mohammed matched!");
                    break;

                case "ali":
                    Console.WriteLine("Yes, Ali matched!");
                    break;

                default:
                    Console.WriteLine("No name matched!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
