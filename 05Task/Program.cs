using System;

namespace _05Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter int number (0-9) : ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 0:
                    Console.WriteLine($"0 = Zero");
                    break;
                case 1:
                    Console.WriteLine($"1 = One ");
                    break;
                case 2:
                    Console.WriteLine($"2 = Two ");
                    break;
                case 3:
                    Console.WriteLine($"3 = Three ");
                    break;
                case 4:
                    Console.WriteLine($"4 = Four");
                    break;
                case 5:
                    Console.WriteLine($"5 = Five");
                    break;
                case 6:
                    Console.WriteLine($"6 = Six");
                    break;
                case 7:
                    Console.WriteLine($"7 = Seven");
                    break;
                case 8:
                    Console.WriteLine($"8= Eight");
                    break;
                case 9:
                    Console.WriteLine($"9 = Nine");
                    break;
                default:
                    Console.WriteLine($"No valid value : {a} ");
                    break;
            }
        }
    }
}
