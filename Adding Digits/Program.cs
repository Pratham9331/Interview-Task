using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sumOfDigits = Sum(number);

        Console.WriteLine("The sum of digits in the number is: " + sumOfDigits);
    }

    static int Sum(int num)
    {
        int sum = 0;

        while (num != 0)
        {
            int digit = num % 10; // Extract the last digit
            sum += digit;        // Add the digit to the sum
            num /= 10;           // Remove the last digit
        }

        return sum;
    }
}