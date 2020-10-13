using System;
using System.IO;
using System.Security.Cryptography;

namespace ProcessingACSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"‪sales_data_sample.csv";

            string[] lines = File.ReadAllLines(filePath);

            //ORDERNUMBER, QUANTITYORDERED, PRICEEACH, ORDERLINENUMBER, SALES
            /*
             * sales = 4
             * status = 6
             * month = 8
             * year = 9
             */

            double sum = 0;
            double sumfor2003 = 0;
            double sumfor2004 = 0;
            double sumfor2005 = 0;
            double jan = 0;
            double feb = 0;
            double mar = 0;
            double apr = 0;
            double may = 0;
            double june = 0;
            double july = 0;
            double aug = 0;
            double sep = 0;
            double oct = 0;
            double nov = 0;
            double dec = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                double sale = Convert.ToDouble(pieces[4]);
                // sum = sum + Convert.ToDouble(pieces[4]);
                if (pieces[6].Trim().ToLower == "shipped")
                {
                    if (year == "2003")
                    {
                        sumfor2003 += sale;
                    }
                    else if (year == "2004")
                    {
                        sumfor2004 += sale;
                    }
                    else
                    {
                        sumfor2005 += sale;
                    }

                    switch (month)
	                {
	                	case"1":
                            jan += sale;
                            break;
                        case"2":
                            feb += sale;
                            break;
                        case"3":
                            mar += sale;
                            break;
                        case"4":
                            apr += sale;
                            break;
                        case"5":
                            may += sale;
                            break;
                        case"6":
                            june += sale;
                            break;
                        case"7":
                            july += sale;
                            break;
                        case"8":
                            aug += sale;
                            break;
                        case"9":
                            sep += sale;
                            break;
                        case"10":
                            oct += sale;
                            break;
                        case"11":
                            nov += sale;
                            break;
                        case"12":
                            dec += sale;
                            break;


                        default:
                          break;
                	}

                    sum += sale;
                }
               
            }

            Console.WriteLine($"The total sales for shipped items in 2003 is {sumfor2003.ToString("C")}.");
            Console.WriteLine($"The total sales for shipped items in 2004 is {sumfor2004.ToString("C")}.");
            Console.WriteLine($"The total sales for shipped items in 2005 is {sumfor2005.ToString("C")}.");

            Console.WriteLine($"Total sales is {sum.ToString("C2")}.");
  

            Console.ReadKey();
        }
    }
}
