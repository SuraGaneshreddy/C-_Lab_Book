// See https://aka.ms/new-console-template for more information
using System;
namespace CheckNumberIsPalindrome
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int original = num;
            int reversed = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            if (original == reversed)
                Console.WriteLine("Number is Palindrome");
            else
                Console.WriteLine("Number is Not Palindrome");
        }
    }
}
