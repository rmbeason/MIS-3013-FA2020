using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double SALES_TAX = 0.085;
            double quantity = 0;
            double itemcost = 0;
            string response = "";

            
            Console.WriteLine("What is the product name of the item you are purchasing? >>");
            response = Console.ReadLine();

            Console.WriteLine("How many items are you purchasing? >>");
            response = Console.ReadLine();
            quantity = Convert.ToDouble(response);

            Console.WriteLine("How much does the item cost? >>");
            response = Console.ReadLine();
            itemcost = Convert.ToDouble(Console.ReadLine());

            double subtotal = (quantity * itemcost);
            double tax = (SALES_TAX * subtotal);
            double salestotal = (subtotal + tax);

            Console.WriteLine();
            Console.WriteLine("subtotal: " + subtotal.ToString("C"));
            Console.WriteLine("tax: " + tax.ToString("C"));
            Console.WriteLine("salestotal: " + salestotal.ToString("C"));

        }
    }
}
