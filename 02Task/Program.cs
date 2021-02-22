using System;

namespace _02Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number : ");
            int c = int.Parse(Console.ReadLine());

            if (a < 0 && b < 0 && c < 0) Console.WriteLine("-");
            else if (a >= 0 && b >= 0 && c >= 0) Console.WriteLine("+");
            else if (a < 0 && b < 0 && c >= 0) Console.WriteLine("+");
            else if (a < 0 && b >= 0 && c < 0) Console.WriteLine("+");
            else if (a >= 0 && b < 0 && c < 0) Console.WriteLine("+");
            else if (a < 0 && b >= 0 && c >= 0) Console.WriteLine("-");
            else if (a >= 0 && b < 0 && c >= 0) Console.WriteLine("-");
            else if (a >= 0 && b >= 0 && c < 0) Console.WriteLine("-");

        }
    }
}
