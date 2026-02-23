// See https://aka.ms/new-console-template for more information
using System;
namespace ArieaCircle
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
    
            double area = Math.PI * radius * radius;
    
            Console.WriteLine("Area of Circle: " + area);
        }
    }
}
