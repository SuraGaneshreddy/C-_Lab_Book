// See https://aka.ms/new-console-template for more information
using System;
namespace ArithmeticOperator0
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
    
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
    
            Console.Write("Enter operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());
    
            double result = 0;
    
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;
    
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;
    
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;
    
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Division by zero not allowed.");
                    }
                    break;
    
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
        }
    }
}
