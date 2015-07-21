using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/// <summary>
/// Solution to the "Sherlock and Array" challenge from https://www.hackerrank.com/challenges/sherlock-and-array
/// </summary>
class Solution
{
    static bool Test(int[] a) {
        int i = 0;
        int sum = 0;
        int total = a.Sum();

        while (i < a.Length && sum < (total - a[i]) / 2) {
            sum += a[i];
            i++;
        }

        return i < a.Length && sum == (total - a[i]) / 2;
    }

    static void Main(String[] args)
    {
        int t = Convert.ToInt16(Console.ReadLine());
        for (int i = 1; i <= t; i++) {
            Console.ReadLine(); // Ingores the length of the input;
            string[] numbers = Console.ReadLine().Split(' ');
            int[] a = (from number in numbers select Convert.ToInt32(number)).ToArray();
            Console.WriteLine(Test(a) ? "YES" : "NO");
        }
    }
}
