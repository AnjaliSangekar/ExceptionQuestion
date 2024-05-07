using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            division();
            Console.WriteLine();
            negative();
            Console.WriteLine();
            fileNotFound();
        }

        public static void division()
        {
            try 
            {
                Console.WriteLine("Enter two number");
                string n1 = Console.ReadLine();
                string n2 = Console.ReadLine();

                double a = Convert.ToDouble(n1);
                double b = Convert.ToDouble(n2);

                if(b != 0)
                {
                    double div = a / b;

                    Console.WriteLine(div);

                }
                else
                {
                    Console.WriteLine("Not divide by zero exception");
                }


            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void negative()
        {
            try
            {
                Console.WriteLine("Enter a number");
                int n = Convert.ToInt32(Console.ReadLine());

                if(n < 0)
                {
                    Console.WriteLine("Negative number exception");
                }
                else
                {
                    Console.WriteLine("Positive number");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public static void fileNotFound()
        {
            Console.WriteLine("Enter file path");
            string filepath = Console.ReadLine();

            try
            {
                using(StreamReader sr = new StreamReader(filepath))
                {
                    Console.WriteLine("File open...");
                }
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("File not found Exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
