using System;

namespace Collections_Beason
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentIds = new int[3];
            double[] gpas = new double[3];
            
            // assign values to studentid's arrays
            studentIds[0] = 1;
            studentIds[1] = 2;
            studentIds[2] = 3;

            //assign values to the gpas's arrays
            gpas[0] = 1.75;
            gpas[1] = 2.99;
            gpas[2] = 4.0;

            for (int i = 0; i < studentIds.Length; i++)
            {
                int studentId = studentIds[i];
                Console.WriteLine(studentId);
            }

            foreach (int studentId in studentIds)
            {
                Console.WriteLine(studentId);
            }

            Console.WriteLine("Please pick an ID to display the GPA of >>");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < studentIds.Length; i++)
            {
                int studentId = studentIds[i];
                if (studentId == id)
                {
                    double gpa = gpas[i];
                    Console.WriteLine($"Student with id {id} has a gpa of {gpa}");
                    break;
                }
            }

            Console.ReadKey();

        }
    }
}
