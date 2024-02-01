using Act1;
using System;
using System.Transactions;

namespace Act1
{
    public class ConsoleApp1
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("The Sum is: " + (num1 + num2));
        }

        public void Subtract(int num1, int num2)
        {
            Console.WriteLine("The Subtraction is: " + (num1 - num2));
        }

        public void Multiply(int num1, int num2)
        {
            Console.WriteLine("The Multiplication is: " + (num1 * num2));
        }

        public void Divide(int num1, int num2)
        {
            Console.WriteLine("The Division is: " + (num1 / num2));
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ConsoleApp1 m = new ConsoleApp1();
        int num1, num2;

        Console.WriteLine("Enter num1 to Add: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter num2 to Add: ");
        num2 = int.Parse(Console.ReadLine());
        m.Add(num1, num2);

        Console.WriteLine("Enter num1 to Subtract: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter num2 to Subtract: ");
        num2 = int.Parse(Console.ReadLine());
        m.Subtract(num1, num2);

        Console.WriteLine("Enter num1 to Multiply: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter num2 to Multiply: ");
        num2 = int.Parse(Console.ReadLine());
        m.Multiply(num1, num2);

        Console.WriteLine("Enter num1 to Divide: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter num2 to Divide: ");
        num2 = int.Parse(Console.ReadLine());
        m.Divide(num1, num2);
    }
}

