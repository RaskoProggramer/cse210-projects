using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();

        Running running = new Running(
            3.0f,
            new DateTime(2026, 10, 3),
            30
        );

        Cycling cycling = new Cycling(
            10.0f,
            new DateTime(2026, 10, 4),
            30
        );

        Swimming swimming = new Swimming(
            20,
            50.0f,
            new DateTime(2022, 10, 5),
            30
        );
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Display summaries
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}