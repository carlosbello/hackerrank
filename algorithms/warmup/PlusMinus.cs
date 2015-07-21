using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Solution to the "Plus Minus" challenge from https://www.hackerrank.com/challenges/plus-minus
/// </summary>
class Solution
{
    static void Main(String[] args)
    {
        double n = Convert.ToDouble(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split(' ');
        int positives = 0,
            negatives = 0,
            zeroes = 0;
        foreach (string number in numbers) {
            int num = Convert.ToInt32(number);
            if (num > 0) positives++;
            else if (num < 0) negatives++;
            else zeroes++;
        }
        Console.WriteLine(Math.Round(positives / n, 3));
        Console.WriteLine(Math.Round(negatives / n, 3));
        Console.WriteLine(Math.Round(zeroes / n, 3));
    }
}
