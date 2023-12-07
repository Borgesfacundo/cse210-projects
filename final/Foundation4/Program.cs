using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(20, "23 Sep 2023", 85);
        Cycling cycling = new Cycling(35, "25 Jul 2022", 120);
        Swimming swimming = new Swimming(10, "14 Feb 2021", 25);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}