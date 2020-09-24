using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //                        012345678910
            string instanceOfString = "Hello World";

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
