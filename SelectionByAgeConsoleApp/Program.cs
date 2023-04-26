using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionByAgeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter Your DOB (MM/DD/YYYY):");
                DateTime dob = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter Age Limit:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Output");
                Console.WriteLine();
                if (age >= 10)
                {
                    Console.WriteLine("You are selected.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You are not selected.");
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
    }
}
