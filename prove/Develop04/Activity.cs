class Activity
{
    private string _activityName;
    private string _description;
    protected int duration;
    private string _startMessage;
    private string _endMessage;

    //Constructor to get activityName, description, startMessage and endMessage
    public Activity(string activityName, string description, string endMessage)
    {
        _activityName = activityName;
        _description = description;
        _endMessage = endMessage;
    }

    //create the starting message for each Activity
    public string GetStartingMessage()
    {
        _startMessage = $"Welcome to {_activityName}. \n {_description}";
        return _startMessage;
    }

    //Ask users about how much time they want to spend in seconds
    public void SetTime()
    {
        Console.WriteLine("How long in seconds, would you like for your session?");
        string answer = Console.ReadLine();
        duration = int.Parse(answer);
        
    }

    public void EndMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed another {duration} seconds of the {_activityName}");
    }
}