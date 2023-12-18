using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SEN_208_Assignment
{
    public class QuadraticEquation
    {
        public static void MainI(string[] args)
        {
            Console.WriteLine("Enter coefficients for the quadratic equation (ax^2 + bx + c = 0):");

            // Get All Data
            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Calculate the discriminant
            double discriminant = b * b - 4 * a * c;

            // Check the nature of roots
            if (discriminant > 0)
            {
                // Two real and distinct roots
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine("Root 1: {0}", root1);
                Console.WriteLine("Root 2: {0}", root2);
            }
            else if (discriminant == 0)
            {
                // Two real and equal roots
                double root = -b / (2 * a);
                Console.WriteLine("Root 1 = Root 2: {0}", root);
            }
            else
            {
                // Complex roots
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);

                Console.WriteLine("Root 1: {0} + {1}i", realPart, imaginaryPart);
                Console.WriteLine("Root 2: {0} - {1}i", realPart, imaginaryPart);
            }

            // Keep the terminal Alive
            Console.ReadKey();
        }
    }
}