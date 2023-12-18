using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SEN_208_Assignment
{
    public class CompoundInterest
    {
        public static void Main(string[] args)
        {
            // Get All Data
            Console.Write("Enter principal amount (e.g: 1000): ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter annual interest rate (e.g: 9): ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number of years (e.g: 5): ");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of times the interest is compounded per year (e.g: 2): ");
            int compoundingFrequency = Convert.ToInt32(Console.ReadLine());

            // Calculate the compound interest
            double perCompoundRate = rate / compoundingFrequency;
            double amount = principal * Math.Pow(1 + perCompoundRate, compoundingFrequency * years);
            double compoundInterest = amount - principal;

            // Show the result
            Console.WriteLine("Compound Interest: {0}", compoundInterest);

            // Keep the terminal Alive
            Console.ReadKey();
        }
    }
}