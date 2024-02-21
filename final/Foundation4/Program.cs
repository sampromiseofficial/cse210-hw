using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Creating activities of each type
        activities.Add(new RunningActivity(new DateTime(2023, 09, 20), 30, 3.0));
        activities.Add(new CyclingActivity(new DateTime(2023, 09, 20), 30, 18.6));
        activities.Add(new SwimmingActivity(new DateTime(2023, 09, 20), 30, 20));

        // Displaying summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}