// See https://aka.ms/new-console-template for more information
using System;
namespace CheckNumberIsArmstrong
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int original = num;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += digit * digit * digit;
                num /= 10;
            }

            if (sum == original)
                Console.WriteLine("Number is Armstrong");
            else
                Console.WriteLine("Number is Not Armstrong");
        }
    }
}