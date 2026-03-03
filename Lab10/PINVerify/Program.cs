// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int correctPin = 1234;
        double balance = 10000;

        Console.Write("Enter PIN: ");
        int enteredPin = Convert.ToInt32(Console.ReadLine());

        if (enteredPin == correctPin)
        {
            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawal successful.");
                Console.WriteLine("Remaining Balance: ₹" + balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
            }
        }
        else
        {
            Console.WriteLine("Incorrect PIN.");
        }
    }
}
