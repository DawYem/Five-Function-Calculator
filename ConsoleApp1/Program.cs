// See https://aka.ms/new-console-template for more information

using System;

namespace Calculator;
//Five function Basic Calculator Add/Sub/Mult/Divide/Percent Program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write the 1st number");
        decimal num1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Write the operation");
        string operation = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Write a 2nd number");
        decimal num2 = Convert.ToDecimal(Console.ReadLine());
        if (operation == "+")
        {

            Console.WriteLine($"Answer is: {num1 + num2}");
        }
        else if (operation == "-")
        {
            Console.WriteLine($"Answer is:{num1 - num2}");
        }
        else if (operation == "*")
        {
            Console.WriteLine($"Answer is:{num1 * num2}");

        }
        else if (operation == "/")
        {
            Console.WriteLine($"Answer is:{num1 / num2}");
        }
        else if (operation == "%")
        {
            Console.WriteLine($"Answer is:{(100 * (num1 / num2))}%");
        }
        else
        {
            Console.WriteLine("ERROR!\n\n\n\n");
        }
    }
}





