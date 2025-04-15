using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("--- Activity Summary ---");
    List <Activity> activities = new List<Activity>();
    activities.Add(new Running("November 24th 2024", 240, 13.8));
    activities.Add(new Cycling("January 6th 2024", 90, 6.3));
    activities.Add(new Swimming("February 15th 2024", 180, 24));
    foreach (var activity in activities)
    {
        Console.WriteLine(activity.GetSummary());
    }
    
    }
}