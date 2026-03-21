// See https://aka.ms/new-console-template for more information
using System;

class Employee
{
    int empId;
    string name;
    double salary;

    // Default constructor
    public Employee()
    {
        empId = 0;
        name = "Unknown";
        salary = 0;
    }

    // Parameterized constructor
    public Employee(int id, string n, double s)
    {
        empId = id;
        name = n;
        salary = s;
    }

    public double AnnualSalary()
    {
        return salary * 12;
    }

    public void Display()
    {
        Console.WriteLine("Employee ID: " + empId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Monthly Salary: " + salary);
        Console.WriteLine("Annual Salary: " + AnnualSalary());
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee(1, "Amit", 30000);

        Console.WriteLine("Employee 1:");
        e1.Display();

        Console.WriteLine("\nEmployee 2:");
        e2.Display();
    }
}
