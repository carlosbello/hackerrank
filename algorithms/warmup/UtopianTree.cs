using System;
using System.IO;

/// <summary>
/// Solution to the "Utopian Tree" challenge from https://www.hackerrank.com/challenges/utopian-tree
/// </summary>
class Solution {

    /// <summary>
    /// Calculate the heigth of the tree, after n growth cicles
    /// </summary>
    /// <remarks>
    /// The idea in this solutions was extracted looking at the serie of the sizes
    /// corresponding to each cicle and the correspondence with the powers of 2.
    /// </remarks>
    /// <param name="n">The number of growth cicles</param>
    /// <returns>The heigth in metters</returns>
    static long calcUtopianTreeHeight(int n) { 
        return (long) Math.Pow(2, (n + (n % 2)) / 2 + 1) - (1 + n % 2);
    }

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= t; i++) {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(calcUtopianTreeHeight(n));
        }
    }
}