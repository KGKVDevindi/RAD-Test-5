using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;

            // Get user input
            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Perform operations
            result = Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {result}");

            result = Subtract(num1, num2);
            Console.WriteLine($"{num1} - {num2} = {result}");

            result = Multiply(num1, num2);
            Console.WriteLine($"{num1} * {num2} = {result}");

            result = Divide(num1, num2);
            Console.WriteLine($"{num1} / {num2} = {result}");

            Console.ReadLine(); // To keep the console window open
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                return double.NaN; // Not a Number to indicate an error
            }
        }
    }
}
