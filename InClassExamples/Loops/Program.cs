using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // add all of the values up from 1 to 100 and output the sum

            int sum = 0;
            // control variable condition; incrementation
            for (int i = 1; i < 101; i++)
            {
                  // sum += 1
                sum = sum + i;
            }

            Console.WriteLine($"The sum of the values from 1 - 100 is {sum}");

            // ask user if they want to perform another iteration until they say

            int iterations = 1;
            Console.WriteLine("Do you want to perform another iteration, yes or no? >>");
            string response = Console.ReadLine();

            while (response.ToLower() == "yes")
            {
                iterations += 1;
                Console.WriteLine("Do you want to perfrom another iteration, yes or no? >>");
                response = Console.ReadLine();
            }

            Console.WriteLine($"The number of iterations (or the times the user said yes) was {iterations}");

            Console.ReadKey(); // waiting for user to press a key to exit
        }
    }
}
