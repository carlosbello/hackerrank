using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Solution to the "Funny String" challenge from https://www.hackerrank.com/challenges/funny-string
/// </summary>
class Solution
{
    static bool IsFunny(string s)
    {
        int l = s.Length;
        bool isFunny = true;
        int i = 1;
        int middle = (int)Math.Round(s.Length / 2d, 0);
        while (isFunny && i <= middle)
        {
            isFunny = Math.Abs((int)s[i] - (int)s[i - 1]) ==
                Math.Abs((int)s[l - i - 1] - (int)s[l - i]);
            i++;
        }
        return isFunny;
    }

    static void Main(String[] args)
    {
        var t = Convert.ToInt32(Console.ReadLine());
        for (var i = 1; i <= t; i++)
        {
            var s = Console.ReadLine();
            Console.WriteLine(IsFunny(s) ? "Funny" : "Not Funny");
        }
    }
}
