using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Solution to the "Staircase" challenge from https://www.hackerrank.com/challenges/staircase
/// </summary>
class Solution
{
    static void Main(String[] args)
    {
        var height = Convert.ToInt32(Console.ReadLine());
        for (var i = 1; i <= height; i++)
        {
            Console.WriteLine(string.Join(" ", new string[height - i + 1]) + string.Join("#", new string[i + 1]));
        }
    }
}