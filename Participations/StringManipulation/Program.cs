using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //                        012345678910
            string instanceOfString = "Hello World";

            char firstletter = instanceOfString[0];

            Console.WriteLine("Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, " +
                "and the universe trying to build bigger and better idiots. So far, the universe is winning");

            Console.WriteLine("What word would you like to look for in the above sentence? >>");
            Console.ReadLine();


            for (int i = 0; i < 100; i = i + 10)
            {
                Console.WriteLine(i);
            }

            instanceOfString = instanceOfString.ToUpper();
            // starting value | condition to loop        |  what assignment happens after each loop
                                                          // this could be i = i + 10 to count by each loop

            for (int i = 0; i < instanceOfString.Length; i++)
            {
                char letter = instanceOfString[i];
                // have to cover the characer to a string to use the string methods
                Console.WriteLine(letter);//.ToString().ToUpper());
            }
        Console.ReadLine(); 
        }
    }
}
