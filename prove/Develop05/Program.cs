using System;

class Program
{
    static void Main(string[] args)
    {

        List<Goal> goals = new List<Goal>();

        Console.WriteLine("Insert Name of goal");
        string name = Console.ReadLine();

        Console.WriteLine("Insert a brief description of goal");
        string description = Console.ReadLine();

        Console.WriteLine("How many poits will you earn each time you complete this goal?");
        string points = Console.ReadLine();
        int point = int.Parse(points);

        EternalGoal eternalGoal = new EternalGoal(name, description, point);
        
        goals.Add(eternalGoal);
        foreach (Goal a in goals)
        {
            string g = a.ToSavedString();
            Console.WriteLine(g);
            
        }

    }
}