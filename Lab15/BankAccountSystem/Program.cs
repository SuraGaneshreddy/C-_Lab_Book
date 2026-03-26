// See https://aka.ms/new-console-template for more information
using System;

// Base class
class Account
{
    protected int accNo;
    protected string name;
    protected double balance;

    public Account(int accNo, string name, double balance)
    {
        this.accNo = accNo;
        this.name = name;
        this.balance = balance;
    }

    public virtual void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: ₹" + amount);
    }

    public virtual void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: ₹" + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }

    public void Display()
    {
        Console.WriteLine("Account No: " + accNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Balance: ₹" + balance);
    }
}

// Derived class - Savings
class SavingsAccount : Account
{
    double interestRate;

    public SavingsAccount(int accNo, string name, double balance, double rate)
        : base(accNo, name, balance)
    {
        interestRate = rate;
    }

    public void AddInterest()
    {
        double interest = balance * interestRate / 100;
        balance += interest;
        Console.WriteLine("Interest Added: ₹" + interest);
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Savings Withdrawn: ₹" + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance in Savings.");
        }
    }
}

// Derived class - Current
class CurrentAccount : Account
{
    double overdraftLimit;

    public CurrentAccount(int accNo, string name, double balance, double limit)
        : base(accNo, name, balance)
    {
        overdraftLimit = limit;
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance + overdraftLimit)
        {
            balance -= amount;
            Console.WriteLine("Current Withdrawn: ₹" + amount);
        }
        else
        {
            Console.WriteLine("Overdraft limit exceeded.");
        }
    }
}

// Main class
class Program
{
    static void Main()
    {
        // Savings Account
        SavingsAccount s = new SavingsAccount(101, "Rahul", 5000, 5);
        Console.WriteLine("=== Savings Account ===");
        s.Deposit(1000);
        s.Withdraw(2000);
        s.AddInterest();
        s.Display();

        // Current Account
        CurrentAccount c = new CurrentAccount(201, "Amit", 3000, 2000);
        Console.WriteLine("\n=== Current Account ===");
        c.Deposit(500);
        c.Withdraw(4500); // uses overdraft
        c.Display();
    }
}
