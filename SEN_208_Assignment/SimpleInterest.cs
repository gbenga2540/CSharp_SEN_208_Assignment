using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SEN_208_Assignment
{
    public class SimpleInterest
    {
        public static void MainI(string[] args)
        {
            // Get All Data
            Console.Write("Enter the principal amount (e.g: 1000): ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the interest rate (e.g: 9): ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the time period in years (e.g: 5): ");
            double time = Convert.ToDouble(Console.ReadLine());

            // Simple Interest Formula --> (PRT/100)
            double SI = (principal * rate * time) / 100;

            // Show the result
            Console.WriteLine("Simple Interest: {0}", SI);

            // Keep the terminal Alive
            Console.ReadKey();
        }
    }
}