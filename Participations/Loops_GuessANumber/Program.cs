using System;
using System.Net;

namespace Loops_GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int number2 = 0;
            int sum = 0;
            string response = Console.ReadLine();
            string response2 = Console.ReadLine();

            Console.WriteLine("what do you want the minimum value to be? >>");
            Console.ReadLine();
            number = Convert.ToInt32(response);
            Console.WriteLine("what do you want the maximum value to be? ??");
            Console.ReadLine();
            number2 = Convert.ToInt32(response2);

            
            Random r = new Random();
            int RandomNum= r.Next(1, 101);
            Console.WriteLine("make a guess between 1 and 100: >>");
            int guess = Convert.ToInt32(Console.ReadLine());
            while (guess = RandomNum)
            {
                Console.WriteLine("sorry! invalid input, enter a valid guess between 1 and 100: >>");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == RandomNum)
                {
                    Console.WriteLine("good job! you guessed correctly");
                    break;
                }

            }

        }
    }
}
