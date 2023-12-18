using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SEN_208_Assignment
{
    public class FibonacciSeries
    {
        public static void Main(string[] args)
        {
            // Get All Inputs
            Console.Write("Enter the number of terms in the Fibonacci series: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Display the result
            Console.WriteLine("\nFibonacci Series:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }

            // Keep the terminal Alive
            Console.ReadKey();


            // FUNCTIONS
            static int Fibonacci(int numOfTerms)
            {
                if (numOfTerms <= 1)
                    return numOfTerms;
                else
                    return Fibonacci(numOfTerms - 1) + Fibonacci(numOfTerms - 2);
            }
        }
    }
}