// See https://aka.ms/new-console-template for more information
using System;

class Student
{
    int rollNo;
    string name;
    double marks;

    // Default constructor
    public Student()
    {
        rollNo = 0;
        name = "Unknown";
        marks = 0;
    }

    // Parameterized constructor
    public Student(int r, string n, double m)
    {
        rollNo = r;
        name = n;
        marks = m;
    }

    public string CalculateGrade()
    {
        if (marks >= 80)
            return "A";
        else if (marks >= 60)
            return "B";
        else if (marks >= 40)
            return "C";
        else
            return "Fail";
    }

    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + CalculateGrade());
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        Student s2 = new Student(101, "Rahul", 75);

        Console.WriteLine("Student 1:");
        s1.Display();

        Console.WriteLine("\nStudent 2:");
        s2.Display();
    }
}
