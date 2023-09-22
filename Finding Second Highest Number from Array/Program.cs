using System;

class Program
{
    static void Main()
    {
        // Input array
        int[] numbers = { 5, 8, 2, 10, 7, 15, 12,12 };

        int highest = 0;
        int secondHigh = 0;

        foreach (int number in numbers)
        {
            if (number > highest)
            {
                secondHigh = highest;
                highest = number;
            }
            else if (number > secondHigh && number != highest)
            {
                secondHigh = number;
            }
        }

        if (secondHigh == 0)
        {
            Console.WriteLine("No second highest element found.");
        }
        else
        {
            Console.WriteLine("The second highest number is: " + secondHigh);
        }
        Console.ReadLine();
    }

}
