using System;

namespace _01Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int toChange;
            Console.Write("Enter first number : ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number :");
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                toChange = firstNumber;
                firstNumber = secondNumber;
                secondNumber = toChange;

            }
            Console.WriteLine($"{firstNumber} {secondNumber}");
        }
    }
}
