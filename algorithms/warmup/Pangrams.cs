using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Solution to the "Pangrams" challenge from https://www.hackerrank.com/challenges/pangrams
/// </summary>
class Solution
{
    static void Main(String[] args)
    {
        const int ALPHABET_LENGTH = 27; // English letters + space
        var s = Console.ReadLine();
        var letters = new HashSet<string>();
        int i = 0;
        while (letters.Count < ALPHABET_LENGTH && i < s.Length)
        {
            letters.Add(s[i].ToString().ToLower());
            i++;
        }
        Console.WriteLine(letters.Count < ALPHABET_LENGTH ? "not pangram" : "pangram");
    }
}
