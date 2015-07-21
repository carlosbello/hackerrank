using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

/// <summary>
/// Solution to the "Extra long factorials" challenge from https://www.hackerrank.com/challenges/extra-long-factorials
/// </summary>
class Solution
{
    static void Main(String[] args)
    {
        var n = Convert.ToByte(Console.ReadLine());
        BigInteger result = new BigInteger(1);
        for (var i = 2; i <= n; i++)
            result = result * i;
        Console.WriteLine(result);
    }
}
