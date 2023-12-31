class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {

    }
    public void Run()
    {
        Console.WriteLine(GetStartingMessage());
        SetTime();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(6);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        //This is making the Activity show the brethe in and breathe out messages for the time the user wants (Seconds)
        while (DateTime.Now < endTime)
        {
            ShowBreathInMessage(4);

            ShowBreathOutMessage(6);
        }
        Console.WriteLine();
        EndMessage();
        ShowSpinner(5);
        Console.Clear();
    }

    public void ShowBreathInMessage(int duration)
    {
        Console.Write("\n \nBreathe in...");
        CountDownTimer(duration);

    }
    public void ShowBreathOutMessage(int duration)
    {
        Console.Write("\nNow breathe out...");
        CountDownTimer(duration);
    }
}