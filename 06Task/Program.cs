using System;

namespace _06Task
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, d,x;
            Console.Write("Enter number a : ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Enter number b : ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Enter number c : ");
            double c = int.Parse(Console.ReadLine());

            d = (b * b) - (4 * a * c);
            if (d==0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine($"{x1} and {x2}");
            }
            else if (d<0)
            {
                Console.WriteLine($"no have real x1 , x2");
            }
            else if (d>0)
            {
                x = (b * b) - (4 * a * c);
                x1 = (-b + ((Math.Sqrt(x)))) / 2 * a;
                x2 = (-b - ((Math.Sqrt(x)))) / 2 * a;
                Console.WriteLine($"{x1} and {x2}");
            }
            


        }
    }
}
