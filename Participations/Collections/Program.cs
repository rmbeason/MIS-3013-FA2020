using System;

namespace Collections
{
    class Program
    {
  
        static void Main(string[] args)
        {
            // assuming there are four exam grades

            int final = 0, min, max;
            int[] grades = new int[4]
            Console.WriteLine("Please enter the student's exam grades >>");

            for (int i = 0; i < 4; i++)
            {
                grades[i] = Convert.ToInt32(Console.ReadLine());
                final += grades[i];
            }

            min grades[0];
            max = grades[0];

            for (int i = 1; i < 4; i++)
            {
                if (grades[i] < min)
                {
                    min = grades[i];
                }
                if (grades[i] > max)
                {
                    max[i] = grades[i];
                }
            }

            Console.WriteLine("Mean score = {0}", final / 4);
            Console.WriteLine("Minimum score = {0}", min);
            Console.WriteLine("Max score = {0}", max);
            Console.ReadLine();
        }
    }
}
