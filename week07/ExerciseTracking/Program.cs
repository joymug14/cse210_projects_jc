using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(new DateTime(2026, 10, 13), 60, 5.0);
        Cycling cycling = new Cycling(new DateTime(2026, 10, 13), 30, 20.0);
        Swimming swimming = new Swimming(new DateTime(2026, 10, 13), 30, 30);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
           
    }
}