// See https://aka.ms/new-console-template for more information
using System;
namespace ElectricityBillCalculator
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter electricity units consumed: ");
            int units = Convert.ToInt32(Console.ReadLine());

            double bill = 0;

            // Slab calculation
            if (units <= 100)
            {
                bill = units * 1.5;
            }
            else if (units <= 200)
            {
                bill = (100 * 1.5) + ((units - 100) * 2.5);
            }
            else
            {
                bill = (100 * 1.5) +
                       (100 * 2.5) +
                       ((units - 200) * 4);
            }

            // Add fixed charge
            bill += 50;

            double gst = 0;

            // Apply GST if bill > 500
            if (bill > 500)
            {
                gst = bill * 0.18;
                bill += gst;
            }

            Console.WriteLine("GST Applied: ₹" + gst);
            Console.WriteLine("Total Electricity Bill: ₹" + bill);
        }
    }
}
