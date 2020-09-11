using System;

namespace Conditional_CoinToss
{
    class Program
    {
        const string DEVELOPER = "Rachel Beason";
        const int HEADS = 1;
        const int TAILS = 0;



        static void Main(string[] args)
        {

            Console.WriteLine("Heads or Tails? >>");
            string answer = Console.ReadLine();

            Random rnd = new Random();
            int result = rnd.Next(0, 2);

            if (result == HEADS && answer == "Heads")
            {
                Console.WriteLine("Correct!");
            }
            else if (result == TAILS && answer == "Tails")
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }


            Console.WriteLine(DEVELOPER);

        }
    }
}
