// See https://aka.ms/new-console-template for more information
using System;
namespace CheckStringIsPalindrome
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            if (input == reversed)
                Console.WriteLine("String is Palindrome");
            else
                Console.WriteLine("String is Not Palindrome");
        }
    }
}
