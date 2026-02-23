// See https://aka.ms/new-console-template for more information
using System;
namespace ClassifyAgeGroup
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 12)
                Console.WriteLine("You are Kid");
            else if (age >= 12 && age <= 17)
                Console.WriteLine("You are Teenager");
            else if (age >= 18 && age <= 60)
                Console.WriteLine("You are Adult");
            else
                Console.WriteLine("You are Senior Citizen");
        }
    }
}
