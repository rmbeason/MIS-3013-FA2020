using System;
using System.Collections.Generic;
using System.Windows.Markup;

namespace Methods
{
    class Program
    {
        static List<int> values = new List<int>();

        static void Main(string[] args)
        {
            Random rand = new Random(); // this is an instance

            int x;
            int.TryParse("cat", out x);
            
            Console.ReadKey();
        }

        
        static bool PossiblyAddStringToAList(string inputFromWhoeverCalledMe)
        {
            bool wasSuccess = true;
            int value;

            wasSuccess = int.TryParse(inputFromWhoeverCalledMe);

            if (wasSuccess)
            {
                //we want to add it to the list
                Values.Add(value);
            }
            else
            {
                  // we want to tell invalid input
            }
            return true;
        }
    }
}
