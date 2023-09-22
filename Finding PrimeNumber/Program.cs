using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1 || number % 2 == 0)
        {
            return false;
        }

        if (number == 2)
        {
            return true;
        }

       

        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (IsPrime(num))
        {
            Console.WriteLine(num + " is a prime number.");
        }
        else
        {
            Console.WriteLine(num + " is not a prime number.");
        }
    }
}
