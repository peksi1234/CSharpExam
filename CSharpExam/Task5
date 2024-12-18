using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary to store items and their definitions
            Dictionary<string, string> Items = new Dictionary<string, string>();

            while (true)
            {
                // Display menu
                Console.WriteLine("1. Add an item and its definition");
                Console.WriteLine("2. Remove an item");
                Console.WriteLine("3. Show all items and their definitions");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Add an item and its definition
                    Console.Write("Enter item name: ");
                    string item = Console.ReadLine();
                    Console.Write("Enter item description: ");
                    string description = Console.ReadLine();

                    // Checks if item already exists
                    if (Items.ContainsKey(item))
                        Console.WriteLine("THis item already exists. Do you want to overwrite it? (yes/no)");
                    string overwrite = Console.ReadLine();
                    Items.Add(item, description);

                }
                else if (choice == "2")
                {
                    // Remove an item
                    Console.Write("Enter the item to remove: ");
                    string itemToRemove = Console.ReadLine();
                    Items.Remove(itemToRemove);
                }
                else if (choice == "3")
                {
                    // Show all items and their definitions
                    foreach (var item in Items)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
                else if (choice == "4")
                {
                    // Exit the program
                    break;
                }
                else
                {
                    // Invalid input handling
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
