class ListActivity : Activity
{
    private List<string> prompts = new List<string>();

    public ListActivity(string activityName, string description) : base(activityName, description)
    {

    }
    private string GetRandomPrompt()
    {
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");

        Random randomPrompt = new Random();
        int number = randomPrompt.Next(prompts.Count);
        
        return prompts[number];
    }
    public void Run()
    {
        Console.WriteLine(GetStartingMessage());
        SetTime();
        Console.Clear();
        Console.Write("Get ready...\n");
        ShowSpinner(6);
        List<string> userAnswer = new List<string>();
        Console.WriteLine("\nList as many responses you can to the following prompt :");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        CountDownTimer(3);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string answer = Console.ReadLine();
            userAnswer.Add(answer);

        }
        Console.WriteLine($"\nYou listed {userAnswer.Count} items!");
        EndMessage();
        ShowSpinner(5);
        Console.Clear();

    }
}