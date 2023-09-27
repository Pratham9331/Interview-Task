using System;

class AnagramNumberChecker
{
    // Function to check if two numbers are anagrams
    static bool Anagrams(int num1, int num2)
    {
        // Convert the numbers to strings to work with their digits
        string s1 = num1.ToString();
        string s2 = num2.ToString();

        // Check if the lengths of the two strings are equal
        if (s1.Length != s2.Length)
        {
            return false;
        }

        // Create character arrays from the strings
        char[] c1 = s1.ToCharArray();
        char[] c2 = s2.ToCharArray();

        // Sort the character arrays
        Array.Sort(c1);
        Array.Sort(c2);

        // Compare the sorted arrays
        for (int i = 0; i < c1.Length; i++)
        {
            if (c1[i] != c2[i])
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        if (Anagrams(num1, num2))
        {
            Console.WriteLine($"{num1} and {num2} are anagram numbers.");
        }
        else
        {
            Console.WriteLine($"{num1} and {num2} are not anagram numbers.");
        }
     
    
    }
}
