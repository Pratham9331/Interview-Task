using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of Fibonacci terms to generate: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        fib0(n);
        Console.ReadLine();
    }

    static void fib0(int n)
    {
        int first = 0, second = 1;

        Console.WriteLine("Fibonacci Series:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(first + " ");

            int next = first + second;
            first = second;
            second = next;
        }

        Console.WriteLine();
    }
}
