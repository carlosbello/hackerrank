using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Solution to the "Time Conversion" challenge from https://www.hackerrank.com/challenges/time-conversion
/// </summary>
class Solution
{
    static void Main(String[] args)
    {
        var fullTime = Console.ReadLine();
        var dayPart = fullTime.Substring(8);
        var timePart = fullTime.Substring(0, 8);
        var hour = Convert.ToByte(fullTime.Substring(0, 2));
        var rest = fullTime.Substring(2, 6);
        var result = "";
        if (fullTime.Length <= 8)
            result = fullTime;
        else if (hour == 12)
            result = dayPart == "AM" ? ("00" + rest) : timePart;
        else {
            result = dayPart == "AM" ? fullTime.Substring(0, 8) : (hour + 12).ToString() + rest;
        }
        Console.WriteLine(result);
    }
}