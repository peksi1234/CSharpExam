using System;
using System.Runtime.Remoting.Channels;

class Program
{
    static void Main(string[] args)
    {
        // Ask for two numbers
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();

        // Perform calculations
        string sum = Add(input1, input2);
        string difference = Subtract(input1, input2);
        string product = Multiply(input1, input2);
        string quotient = Divide(input1, input2);

        // Print results
        Console.WriteLine($"The sum of the numbers is: {sum}.0");
        Console.WriteLine($"The difference of the numbers is: {difference}.0");
        Console.WriteLine($"The product of the numbers is: {product}.0");
        Console.WriteLine($"The quotient of the numbers is: {quotient}.0");

        Console.ReadLine();
    }


    static string Add(string num1, string num2)
    {
        int n1 = int.Parse(num1);
        int n2 = int.Parse(num2);
        return (n1 + n2).ToString();
    }

    static string Subtract(string num1, string num2)
    {
        int n1 = int.Parse(num1);
        int n2 = int.Parse(num2);
        return (n1 - n2).ToString();
    }

    static string Multiply(string num1, string num2)
    {
        int n1 = int.Parse(num1);
        int n2 = int.Parse(num2);
        return (n1 * n2).ToString();
    }

    static string Divide(string num1, string num2)
    {
        int n1 = int.Parse(num1);
        int n2 = int.Parse(num2);
        if (n2 == 0)
            return "Cannot divide by zero";
        return (n1 / n2).ToString();
    }
}
