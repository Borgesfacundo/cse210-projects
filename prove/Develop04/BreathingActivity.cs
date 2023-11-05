class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {

    }
    public void Run()
    {
        GetStartingMessage();
        SetTime();
        CountDownTimer(500);
        ShowSpinner(7);
    }

    
}