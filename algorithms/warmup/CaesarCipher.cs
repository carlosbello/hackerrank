using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/// <summary>
/// Solution to the "Caesar Cipher" challenge from https://www.hackerrank.com/challenges/caesar-cipher-1
/// </summary>
class Solution
{
    const int LOWER_A_ASCII = (int)'a';
    const int LETTERS_COUNT = (int)'z' - (int)'a' + 1;
    const int UPPER_A_ASCII = (int)'A';


    static bool IsLower(char letter)
    {
        return 'a' <= letter && letter <= 'z';
    }

    static bool IsUpper(char letter)
    {
        return 'A' <= letter && letter <= 'Z';
    }

    static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var s = Console.ReadLine();
        var k = Convert.ToInt32(Console.ReadLine());
        var result = new char[n];
        for (int i = 0; i < n; i++)
        {
            char letter = s[i];
            if (IsLower(letter))
            {
                result[i] = (char)(((int)letter - LOWER_A_ASCII + k) % LETTERS_COUNT + LOWER_A_ASCII);
            }
            else if (IsUpper(letter))
            {
                result[i] = (char)(((int)letter - UPPER_A_ASCII + k) % LETTERS_COUNT + UPPER_A_ASCII);
            }
            else
            {
                result[i] = letter;
            }
        }
        Console.WriteLine(new string(result));
    }
}