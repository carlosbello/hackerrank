using System;
using System.IO;

/// <summary>
/// Solution to the "Chocolate Feast" challenge from https://www.hackerrank.com/challenges/chocolate-feast
/// </summary>
class Solution {
    const char SPACE = (char)32;

    static long ChocolatesGot(int money, int price, int requiredForDiscount) {
        int gotFromMoney = money / price;
        int notUsedToGotExtras = gotFromMoney;
        int gotExtra;
        long totalGot = gotFromMoney;
        do {
            gotExtra = notUsedToGotExtras / requiredForDiscount;
            totalGot += gotExtra;
            notUsedToGotExtras = gotExtra + notUsedToGotExtras % requiredForDiscount;
        } while (notUsedToGotExtras >= requiredForDiscount);
        return totalGot;
    }

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= t; i++) {
            int[] test = Array.ConvertAll(Console.ReadLine().Split(SPACE), Convert.ToInt32);
            Console.WriteLine(ChocolatesGot(test[0], test[1], test[2]));
        }
    }
}