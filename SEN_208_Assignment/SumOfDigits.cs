using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SEN_208_Assignment
{
    public class SumOfDigits
    {
        public static void Main(string[] args)
        {
            // Get All Inputs
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Using a for loop, iterate through each digit and Add the last digit to the total.
            int total = 0;
            for (; number != 0; number /= 10)
            {
                total += number % 10;
            }

            // Display the result
            Console.WriteLine("Sum of digits: {0}", total);

            // Keep the terminal Alive
            Console.ReadKey();
        }
    }
}