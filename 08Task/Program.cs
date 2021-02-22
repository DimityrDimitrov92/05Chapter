using System;

namespace _08Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter (0) > double , (1) > int , (2) > string : ");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 0:
                    Console.Write("Enter a double : ");
                    double isDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Double {isDouble} = {isDouble} + 1 = {isDouble+1}" );
                    break;
                case 1:
                    Console.Write("Enter a int : ");
                    int isInt = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Int {isInt} = {isInt} + 1 = {isInt +1}");
                    break;
                case 2:
                    Console.Write("Enter string : ");
                    string isString = Console.ReadLine();
                    Console.WriteLine($"String {isString} = {isString} + * = {isString+'*'}");
                    break;
            }


        }
    }
}
