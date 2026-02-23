// See https://aka.ms/new-console-template for more information
using System;
namespace PrimeNumber0
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            if (num <= 1)
                isPrime = false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine("Number is Prime");
            else
                Console.WriteLine("Number is Not Prime");
        }
    }
}
