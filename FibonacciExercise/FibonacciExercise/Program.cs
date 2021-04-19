using System;

namespace FibonacciExercise
{
    internal class Program
    {
        static void FibonacciNumber(int num1, int num2, int n, int counter)
        {
            if (counter <= n)
            {
                if (counter < n)
                    Console.Write($"{num1}, ");
                else
                    Console.Write($"{num1}");

                FibonacciNumber(num2, num1 + num2, n, counter + 1);
            }
        }

        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number");
                int n = int.Parse(Console.ReadLine());
                FibonacciNumber(0, 1, n, 1);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error while processing, ErrorMessage:{e.Message}");
            }
        }
    }
}
