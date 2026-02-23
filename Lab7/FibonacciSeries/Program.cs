// See https://aka.ms/new-console-template for more information
using System;
namespace FibonacciSeries
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int first = 0, second = 1;

            Console.WriteLine("Fibonacci Series:");

            while (first <= limit)
            {
                Console.Write(first + " ");
                int next = first + second;
                first = second;
                second = next;
            }
        }
    }
}
