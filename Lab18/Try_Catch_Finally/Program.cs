// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");

        try
        {
            int number = int.Parse(Console.ReadLine());

            int result = 50 / number;

            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
        }
        finally
        {
            Console.WriteLine("This block always executes.");
        }

        Console.WriteLine("Program ended.");
    }
}
