using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SEN_208_Assignment
{
    public class SumOfDigits
    {
        public static void MainI(string[] args)
        {
            // Get All Data
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Iterate through each digit using a for loop and Add the last digit to the sum.
            int sum = 0;
            for (; number != 0; number /= 10)
            {
                sum += number % 10;
            }

            Console.WriteLine("Sum of digits: {0}", sum);

            // Keep the terminal Alive
            Console.ReadKey();
        }
    }
}