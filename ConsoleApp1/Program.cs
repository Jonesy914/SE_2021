using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 6, num2 = 3, sum = 0;

            sum = num1 + num2;
            Console.WriteLine("Hello World!\n My sum is equal to " + sum);

            sum = num1 * num2;

            Console.WriteLine("Hi James, I've multiplied them :) " + sum);

            sum = num1 / num2;

            Console.WriteLine("Hi James, I've divided them :) " + sum);
        }
    }
}
