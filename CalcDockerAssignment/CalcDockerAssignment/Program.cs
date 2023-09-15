using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDockerAssignment
{
    internal class Program
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }

        public static double Exponentiate(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        static void Main()
        {
            Console.WriteLine("Welcome to My Calculator App");
            Console.Write("Enter the first number: ");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Enter the second number: ");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine($"Result of addition: {Add(num1, num2)}");
                    Console.WriteLine($"Result of subtraction: {Subtract(num1, num2)}");
                    Console.WriteLine($"Result of multiplication: {Multiply(num1, num2)}");
                    try
                    {
                        Console.WriteLine($"Result of division: {Divide(num1, num2)}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    Console.WriteLine($"Result of exponentiation: {Exponentiate(num1, num2)}");
                }
                else
                {
                    Console.WriteLine("Invalid second number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid first number.");
            }
        }
    }
}
