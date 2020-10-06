using System;

namespace ProcessingACSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"sales_data_sample.csv";

            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }
    }
}
