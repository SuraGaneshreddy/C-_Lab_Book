// See https://aka.ms/new-console-template for more information
using System;
namespace InputRadiusAreaCircle
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine("Area of Circle: " + area);
        }
    }
}
