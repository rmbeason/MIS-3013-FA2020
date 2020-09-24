using System;

namespace practice_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int answer;

            if (input == 10)
            {
                answer = 10 * input;
            }
            else
            {
                answer = input;
            }
        }

    }
}
