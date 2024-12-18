﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get an integer input
            Console.WriteLine("Enter an int: ");
            int userInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Integer: " + userInt);

            // Get a double input
            Console.WriteLine("Enter a double: ");
            double userDouble = double.Parse(Console.ReadLine());
            Console.WriteLine("Double: " + userDouble);

            // Get a float input
            Console.WriteLine("Enter a float: ");
            float userFloat = float.Parse(Console.ReadLine());
            Console.WriteLine("Float: " + userFloat);

            // Get a string input
            Console.WriteLine("Enter a string: ");
            string userString = Console.ReadLine();
            Console.WriteLine("String: " + userString);

            // Brief descriptions of data types
            Console.WriteLine("brief descriptions of data types");
            Console.WriteLine("int: whole numbers, no decimals like 1,2,3");
            Console.WriteLine("double: precise decimals like 1.22123");
            Console.WriteLine("float: decimals with less precision, needs 'f' like 1.04f");
            Console.WriteLine("string: text or characters");

            Console.ReadLine();
        }
    }
}