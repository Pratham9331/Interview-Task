using System;
using System.Globalization;

class Program
{
    static bool IsPalindrome(string s)
    {
        s = s.ToLower(); // Convert the string to lowercase to ignore case
        //s = new string(Array.FindAll(s.ToCharArray(), char.IsLetterOrDigit)); // Remove non-alphanumeric characters
        s = new string(Array.FindAll(s.ToCharArray(), char.IsLetterOrDigit));
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false; // Characters at the current positions don't match
            }
            left++;
            right--;
        }
        return true; // All characters matched, so it's a palindrome
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to check for palindrome:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("It's a palindrome.");
        }
        else
        {
            Console.WriteLine("It's not a palindrome.");
        }

        string reverse = string.Empty;
        int len = input.Length;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverse = reverse + input[i];
        }
        if (input == reverse)
        {
            Console.WriteLine($"Given {input} Input Is  a Palindrome");
        }
        else
        {
            Console.WriteLine("Not a Palindrome.");
        }
        Console.ReadLine();
    }
}
