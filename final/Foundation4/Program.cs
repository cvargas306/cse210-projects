using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(DateTime.Parse("08 April 2024"), 30, 3.0),
            new Cycling(DateTime.Parse("09 April 2024"), 30, 10.0),
            new Swimming(DateTime.Parse("10 April 2024"), 30, 20),
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}