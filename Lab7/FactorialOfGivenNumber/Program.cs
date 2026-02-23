// See https://aka.ms/new-console-template for more information
using System;
namespace FactorialOfGivenNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            long factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Factorial: " + factorial);
        }
    }
}
