using System;

namespace _10Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter int number : ");
            int a = int.Parse(Console.ReadLine());

            if (a>=1 && a<=3)
            {
                Console.WriteLine($"Bonus point of 10x{a} = {a*10}");
            }
            else if (a>=4 &&  a<=6)
            {
                Console.WriteLine($"Bonus point of 100x{a} = {a*100}");
            }
            else if (a>=7 && a<=9)
            {
                Console.WriteLine($"Bonus point of 1000x{a} = {a*1000}");
            }
            else
            {
                Console.WriteLine($"You dont enter right value");
            }
        }
    }
}
