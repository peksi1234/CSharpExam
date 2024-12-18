using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask for a number
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            // Try to convert input to an int
            if (int.TryParse(input, out int number))
            {
                // Check if the number is positive, negative, or zero
                if (number > 0)
                    Console.WriteLine("The number is positive");
                else if (number < 0)
                    Console.WriteLine("The number is negative");
                else
                    Console.WriteLine("The number is zero");
            }
            else
            {
                // Invalid input
                Console.WriteLine("Invalid input");

                Console.ReadLine();
            }
        }
    }
}
