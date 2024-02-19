using System;

class Program
{
    static void Main(string[] args)
     {
        List<Activity> activities = new List<Activity>();

        // Create activities of each type
        activities.Add(new Running(DateTime.Parse("2022-11-03"), 30, 3.0));
        activities.Add(new Cycling(DateTime.Parse("2022-11-03"), 30, 6.0));
        activities.Add(new Swimming(DateTime.Parse("2022-11-03"), 30, 10));

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}