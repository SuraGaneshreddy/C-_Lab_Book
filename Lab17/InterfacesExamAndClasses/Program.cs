// See https://aka.ms/new-console-template for more information
using System;

// Interface Exam
interface Exam
{
    bool Pass(int mark);
}

// Interface Classify
interface Classify
{
    string Division(int average);
}

// Class implementing both interfaces
class Result : Exam, Classify
{
    public bool Pass(int mark)
    {
        if (mark >= 50)
            return true;
        else
            return false;
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

        bool passStatus = r.Pass(mark);
        string division = r.Division(avg);

        Console.WriteLine("Pass Status: " + (passStatus ? "Pass" : "Fail"));
        Console.WriteLine("Division: " + division);
    }
}
