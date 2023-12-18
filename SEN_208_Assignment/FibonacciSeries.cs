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
            // Get All Data
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
            static int Fibonacci(int n)
            {
                if (n <= 1)
                    return n;
                else
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}