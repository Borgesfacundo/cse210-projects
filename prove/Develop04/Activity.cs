class Activity
{
    private string _activityName;
    private string _description;
    protected int duration;
    private string _startMessage;
    DateTime startTime = DateTime.Now;

    //Constructor to get activityName, description, startMessage and endMessage
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    //create the starting message for each Activity
    protected string GetStartingMessage()
    {
        _startMessage = $"Welcome to {_activityName}. \n \n{_description}\n";
        return _startMessage;
    }

    //Ask users about how much time they want to spend in seconds
    protected int SetTime()
    {
        Console.WriteLine("How long in seconds, would you like for your session?");
        string answer = Console.ReadLine();
        duration = int.Parse(answer);
        return duration;
    }

    protected void EndMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {duration} seconds of the {_activityName}");
    }
    protected void CountDownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }
    protected void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;

        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }

    }
    // public void ClearCharacters(int charCount)
    // {
    //     string clear = "\b";
    //     for (int i = 0; i <= charCount; i++)
    //     {
    //         clear += " \b";
    //     }
    //     Console.Write(clear);
    // }
}