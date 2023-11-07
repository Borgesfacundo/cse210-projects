class ReflectingActivity : Activity
{
    private List<string> prompts = new List<string>();
    private List<string> questions = new List<string>();

    public ReflectingActivity(string activityName, string description) : base(activityName, description)
    {

    }

    public string GetRandomPrompt()
    {
        questions.Add("Think of a time when you stood up for someone else.");
        questions.Add("Think of a time when you did something really difficult.");
        questions.Add("Think of a time when you helped someone in need.");
        questions.Add("Think of a time when you did something truly selfless.");

        Random randomQuestion = new();
        int number = randomQuestion.Next(questions.Count);
        return questions[number];
    }

    public string GetRandomQuestion()
    {
        prompts.Add("Why was this experience meaningful to you?");
        prompts.Add("Have you ever done anything like this before?");
        prompts.Add("How did you get started?");
        prompts.Add("How did you feel when it was complete?");
        prompts.Add("What made this time different than other times when you were not as successful?");
        prompts.Add("What is your favorite thing about this experience?");
        prompts.Add("What could you learn from this experience that applies to other situations?");
        prompts.Add("What did you learn about yourself through this experience?");
        prompts.Add("How can you keep this experience in mind in the future?");

        Random randomPrompt = new();
        int number = randomPrompt.Next(prompts.Count);
        return prompts[number];
    }

    public void Run()
    {
        Console.WriteLine(GetStartingMessage());
        SetTime();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(6);

        //Give a random question to the user
        Console.WriteLine("\nConsider the following prompt: \n");
        Console.Write($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");

        Console.Write("You may begin in: ");
        CountDownTimer(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"\n{GetRandomQuestion()} ");
            ShowSpinner(10);

        }
        Console.WriteLine();
        EndMessage();
        ShowSpinner(5);
        Console.Clear();


    }
}