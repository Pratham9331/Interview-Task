using System;

class Program
{
    static void Main()
    {
        // Input array
        int[] numbers = { 5, 8, 2, 10, 7, 15, 12, 8, 15 };

        int firstMax = int.MinValue;
        int secondMax = int.MinValue;
        int thirdMax = int.MinValue;

        foreach (int number in numbers)
        {
            if (number > firstMax)
            {
                thirdMax = secondMax;
                secondMax = firstMax;
                firstMax = number;
            }
            else if (number > secondMax && number != firstMax)
            {
                thirdMax = secondMax;
                secondMax = number;
            }
            else if (number > thirdMax && number != secondMax && number != firstMax)
            {
                thirdMax = number;
            }
        }

        if (thirdMax == int.MinValue)
        {
            Console.WriteLine("No third highest element found.");
        }
        else
        {
            Console.WriteLine("The third highest number is: " + thirdMax);
        }
    }
}
