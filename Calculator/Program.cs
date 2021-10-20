using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter secpnd number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose the method ('+', '/', '-', '*' )");
            char userOperator = Convert.ToChar(Console.ReadLine()); 
            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(num1, num2);
                    break;
                case '/':
                    DivideTwoNumbers(num1, num2);
                    break;
                case '-':
                    SubtractTwoNumbers(num1, num2);
                    break;
                case '*':
                    MultiplyTwoNumbers(num1, num2);
                    break;
                default:
                    Console.WriteLine("Wrong calculation.");
                    break;
            }

        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }
        private static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
        }
        private static void SubtractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }
        private static void MultiplyTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
        }
    }
}
