using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("28 Oct 2024", 45, 5);
        activities.Add(running);

        Cycling cycling = new Cycling("30 Oct 2024", 30, 8.5);
        activities.Add(cycling);

        Swimming swimming = new Swimming("02 Nov 2024", 60, 35);
        activities.Add(swimming);

        Console.WriteLine("Exercises:\n");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}