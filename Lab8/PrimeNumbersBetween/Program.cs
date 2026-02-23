// See https://aka.ms/new-console-template for more information
using System;
namespace PrimeNumbersBetween
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers between " + start + " and " + end + ":");

            for (int num = start; num <= end; num++)
            {
                if (num <= 1)
                    continue;

                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.Write(num + " ");
            }
        }
    }
}
