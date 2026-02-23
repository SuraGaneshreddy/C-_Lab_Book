// See https://aka.ms/new-console-template for more information
using System;
namespace SimpleInterest
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter Principal Amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());
    
            Console.Write("Enter Rate of Interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());
    
            Console.Write("Enter Time (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());
    
            double simpleInterest = (principal * rate * time) / 100;
    
            Console.WriteLine("Simple Interest: " + simpleInterest);
        }
    }
}