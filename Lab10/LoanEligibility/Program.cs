// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter monthly income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter credit score: ");
        int creditScore = Convert.ToInt32(Console.ReadLine());

        if (age >= 21 && age <= 60)
        {
            if (income >= 25000)
            {
                if (creditScore >= 700)
                {
                    Console.WriteLine("Loan Approved");
                }
                else
                {
                    Console.WriteLine("Loan Rejected: Low Credit Score");
                }
            }
            else
            {
                Console.WriteLine("Loan Rejected: Insufficient Income");
            }
        }
        else
        {
            Console.WriteLine("Loan Rejected: Age Not Eligible");
        }
    }
}
