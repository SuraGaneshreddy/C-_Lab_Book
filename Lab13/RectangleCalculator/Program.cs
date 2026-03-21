// See https://aka.ms/new-console-template for more information
using System;

class Rectangle
{
    double length, width;

    // Default constructor
    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    // Parameterized constructor
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double Area()
    {
        return length * width;
    }

    public void Display()
    {
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area: " + Area());
    }
}

class Program
{
    static void Main()
    {
        Rectangle r1 = new Rectangle(); // default
        Rectangle r2 = new Rectangle(10, 5); // parameterized

        Console.WriteLine("Rectangle 1:");
        r1.Display();

        Console.WriteLine("\nRectangle 2:");
        r2.Display();
    }
}
