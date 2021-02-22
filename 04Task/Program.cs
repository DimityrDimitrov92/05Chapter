using System;

namespace _04Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine($" {a} , {b} ,{c}");
                }
                else
                {
                    Console.WriteLine($" {a} , {c} , {b}");
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine($"{b} , {a} ,{c}");
                }
                else
                {
                    Console.WriteLine($"{b} , {c} , {a}");
                }
            }
            else
            {
                if (b>c)
                {
                    Console.WriteLine($"{c} , {b} , {a}");
                }
                else
                {
                    Console.WriteLine($"{c} , {a} , {b}");
                }
            }
         }
    }
}
