using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SEN_208_Assignment
{
    public class PalindromeChecker
    {
        public static void MainI(string[] args)
        {
            // Get All Data
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPalindrome(number))
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }

            // Keep the terminal Alive
            Console.ReadKey();


            // FUNCTIONS
            static bool IsPalindrome(int num)
            {
                int originalNumber = num;
                int reversedNumber = 0;
                while (num > 0)
                {
                    int remainder = num % 10;
                    reversedNumber = reversedNumber * 10 + remainder;
                    num /= 10;
                }
                return originalNumber == reversedNumber;
            }
        }
    }
}