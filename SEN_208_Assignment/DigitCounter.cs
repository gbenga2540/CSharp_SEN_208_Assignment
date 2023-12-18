using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SEN_208_Assignment
{
    public class DigitCounter
    {
        public static void Main(string[] args)
        {
            // Get All Inputs
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int tempNum = number;

            // We count the digits using a loop, we start by handling negative numbers and initializing count to 0.
            int count = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                number /= 10;
                count++;
            }

            // Display the result
            Console.WriteLine("The number of digits in {0} is: {1}", tempNum, count);

            // Keep the terminal Alive
            Console.ReadKey();
        }
    }
}