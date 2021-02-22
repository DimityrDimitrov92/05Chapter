using System;

namespace _03Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggest;
            Console.Write("Enter first number : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number : ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c )
            {
                biggest = a;
            }
            else if (b > a && b > c)
            {
                biggest = b;
            }else
            {
                biggest = c;
            }
            Console.WriteLine(biggest);
        }
    }
}
