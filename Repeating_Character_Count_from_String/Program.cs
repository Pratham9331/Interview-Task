using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "ilovee thhe retrieve myy anndd information";
        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            Dictionary<char, int> charCount = CountRepetitiveAlphabets(word);

            Console.WriteLine($"Word: {word}");
            foreach (var kvp in charCount)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }
            Console.WriteLine();
        }
    }

    static Dictionary<char, int> CountRepetitiveAlphabets(string input)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char lowercaseChar = char.ToLower(c);

                if (charCount.ContainsKey(lowercaseChar))
                {
                    charCount[lowercaseChar]++;
                }
                else
                {
                    charCount[lowercaseChar] = 1;
                }
            }
        }

        Dictionary<char, int> repetitiveCharCount = new Dictionary<char, int>();

        foreach (var kvp in charCount)
        {
            if (kvp.Value > 1)
            {
                repetitiveCharCount.Add(kvp.Key, kvp.Value);
            }
        }

        return repetitiveCharCount;
    }
}