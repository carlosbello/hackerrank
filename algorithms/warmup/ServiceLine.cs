using System;
using System.IO;

/// <summary>
/// Solution to the "Service Line" challenge from
/// https://www.hackerrank.com/challenges/service-lane
/// </summary>
class Solution {
    const char SPACE = (char)32;

    static byte SmalestWidth(byte[] width, int i, int j) {
        byte smalest = byte.MaxValue;
        for (int index = i; index <= j; index++) 
            smalest = Math.Min(smalest, width[index]);
        return smalest;
    }

    static void Main(String[] args) {
        string[] parameters = Console.ReadLine().Split(SPACE);
        int n = Convert.ToInt32(parameters[0]);
        int t = Convert.ToInt32(parameters[1]);
        byte[] width = Array.ConvertAll(Console.ReadLine().Split(SPACE), Convert.ToByte);
        byte[] largestVehicle = new byte[t];
        for (int count = 1; count <= t; count++) {
            string[] testCase = Console.ReadLine().Split(SPACE);
            int i = Convert.ToInt32(testCase[0]);
            int j = Convert.ToInt32(testCase[1]);
            largestVehicle[count-1] = SmalestWidth(width, i, j);
        }
        foreach (byte vehicle in largestVehicle)
            Console.WriteLine(vehicle);
    }
}