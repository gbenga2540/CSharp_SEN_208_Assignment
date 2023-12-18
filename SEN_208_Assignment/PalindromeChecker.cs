using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SEN_208_Assignment
{
    public class PalindromeChecker
    {
        public static void Main(string[] args)
        {
            // Get All Inputs
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Run checks and Display the result
            if (IsPalindrome(number))
            {
                Console.WriteLine("{0} is a palindrome.", number);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome.", number);
            }

            // Keep the terminal Alive
            Console.ReadKey();


            // FUNCTIONS
            static bool IsPalindrome(int num)
            {
                // A number that reads the same foward as backward
                int origNumber = num;
                int revNumber = 0;
                while (num > 0)
                {
                    int remainder = num % 10;
                    revNumber = revNumber * 10 + remainder;
                    num /= 10;
                }
                return origNumber == revNumber;
            }
        }
    }
}