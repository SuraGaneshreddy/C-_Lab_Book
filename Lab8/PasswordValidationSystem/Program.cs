// See https://aka.ms/new-console-template for more information
using System;
namespace PasswordValidationSystem
{
    class Program
    {
        static void Main()
        {
            string password;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();

                bool hasUpper = false;
                bool hasLower = false;
                bool hasDigit = false;
                bool hasSpecial = false;

                if (password.Length < 8)
                {
                    Console.WriteLine("Password must be at least 8 characters long.");
                    continue;
                }

                foreach (char ch in password)
                {
                    if (char.IsUpper(ch))
                        hasUpper = true;
                    else if (char.IsLower(ch))
                        hasLower = true;
                    else if (char.IsDigit(ch))
                        hasDigit = true;
                    else
                        hasSpecial = true;
                }

                if (!hasUpper)
                    Console.WriteLine("Password must contain at least one uppercase letter.");
                if (!hasLower)
                    Console.WriteLine("Password must contain at least one lowercase letter.");
                if (!hasDigit)
                    Console.WriteLine("Password must contain at least one digit.");
                if (!hasSpecial)
                    Console.WriteLine("Password must contain at least one special character.");

                if (hasUpper && hasLower && hasDigit && hasSpecial)
                {
                    isValid = true;
                    Console.WriteLine("Password accepted.");
                }
                else
                {
                    Console.WriteLine("Try again.\n");
                }
            }
        }
    }
}
