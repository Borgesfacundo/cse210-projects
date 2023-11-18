using System;

class Program
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        int userInput = -1;
        List<Goal> goalsList = new List<Goal>();

        while (userInput < 6)
        {

            Console.WriteLine($"\nYou have {totalPoints} points. \n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("   1. Simple Goal");
                Console.WriteLine("   2. Eternal Goal");
                Console.WriteLine("   3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                int answer = int.Parse(Console.ReadLine());

                if (answer == 1)
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    goalsList.Add(simpleGoal);
                }
                if (answer == 2)
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    goalsList.Add(eternalGoal);
                }
                if (answer == 3)
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int timesToAcomplish = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, timesToAcomplish, bonusPoints);
                    goalsList.Add(checklistGoal);
                }
            }
            if (userInput == 2)
            {
                foreach (Goal goals in goalsList)
                {
                    Console.WriteLine(goals.ToString());
                }
            }
        }
    }
}