using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/// <summary>
/// Solution to the "Library Fine" challenge from https://www.hackerrank.com/challenges/library-fine
/// </summary>
class Solution
{
    const int YEAR = 2;
    const int MONTH = 1;
    const int DAY = 0;

    static void Main(String[] args)
    {
        var current = (from n in Console.ReadLine().Split(' ') select Convert.ToInt16(n)).ToArray();
        var expected = (from n in Console.ReadLine().Split(' ') select Convert.ToInt16(n)).ToArray();
        var fine = 0;
        if (current[YEAR] > expected[YEAR])
            fine = 10000;
        else if (current[YEAR] == expected[YEAR])
        {
            if (current[MONTH] > expected[MONTH])
                fine = 500 * (current[MONTH] - expected[MONTH]);
            else if (current[MONTH] == expected[MONTH] && current[DAY] > expected[DAY])
                fine = 15 * (current[DAY] - expected[DAY]);
        }
        Console.WriteLine(fine);
    }
}
