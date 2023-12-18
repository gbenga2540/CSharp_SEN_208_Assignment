using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SEN_208_Assignment
{
    public class DigitCounter
    {
        public static void MainI(string[] args)
        {
            // Get All Data
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int digitCount = CountDigits(number);
            // Display the result
            Console.WriteLine($"The number of digits in {number} is: {digitCount}");

            // Keep the terminal Alive
            Console.ReadKey();


            // Functions
            static int CountDigits(int num)
            {
                // Count digits using a loop, we start by handling negative numbers and initializing count to 0.
                num = Math.Abs(num);
                int count = 0;
                while (num > 0)
                {
                    num /= 10;
                    count++;
                }
                return count;
            }
        }
    }
}