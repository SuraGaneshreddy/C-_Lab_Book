// See https://aka.ms/new-console-template for more information
using System;

// Interface 1
interface Exam
{
    bool Pass(int mark);
}

// Interface 2
interface Classify
{
    string Division(int average);
}

// Class implementing both interfaces
class Result : Exam, Classify
{
    public bool Pass(int mark)
    {
        return mark >= 50;
    }

    public string Division(int average)
    {
        if (average >= 60)
            return "First";
        else if (average >= 50)
            return "Second";
        else
            return "No Division";
    }
}

// Main class
class Program
{
    static void Main()
    {
        Result r = new Result();

        Console.Write("Enter marks: ");
        int mark = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter average: ");
        int avg = Convert.ToInt32(Console.ReadLine());

        bool result = r.Pass(mark);
        string division = r.Division(avg);

        Console.WriteLine("Pass Status: " + (result ? "Pass" : "Fail"));
        Console.WriteLine("Division: " + division);
    }
}
