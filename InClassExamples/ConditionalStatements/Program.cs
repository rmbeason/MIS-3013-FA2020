using System;
using System.Collections.Concurrent;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 0;
            double distance = 0;
            string response = "";
            bool containsHazardous = false;

            Console.WriteLine("What is the weight of your shipment, in pounds? >>");
            response = Console.ReadLine();
            weight = Convert.ToDouble(response);

            Console.WriteLine("What is the distance of your shipment, in miles? >>");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Does your shipment contain any hazardous material, yes or no? >>");
            response = Console.ReadLine();

            if (response == "yes")
            {
                containsHazardous = true;
            }
            else if (response == "no")
            {
                containsHazardous = false;
            }
            else
            {
                Console.WriteLine("INVALID INPUT, GOODBYE!");
                return;
            }
        }
    }
}
            
            
    

