using System;

namespace _07Task
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
            Console.Write("Enter  third number : ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth number : ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter fifth number : ");
            int e = int.Parse(Console.ReadLine());

            //if (a>b && a>c && a > d && a > e)
            //{
            //    biggest = a;
            //    Console.WriteLine($"The biggest number is {biggest}");
            //}
            //else if (b>a && b>c && b>d && b> e)
            //{
            //    biggest = b;
            //    Console.WriteLine($"The biggest number is {biggest}");
            //}
            //else if (c>a && c>b && c>d && c>e)
            //{
            //    biggest = c;
            //    Console.WriteLine($"The biggest number is {biggest}");
            //}
            //else if (d>a && d>b && d>c && d>e)
            //{
            //    biggest = d;
            //    Console.WriteLine($"The biggest number is {biggest}");
            //}
            //else if (e>a && e>b && e >c && e>d)
            //{
            //    biggest = e;
            //    Console.WriteLine($"The biggest number is {biggest}");
            //}
            if (a < b) { a = b; }
            if (a < c) { a = c; }
            if (a < d) { a = d; }
            if (a < e) { a = e; }
            Console.WriteLine($"the biggest number is : {a}");
            
        }
    }
}
