class ChecklistGoal : CompletableGoal
{
    private int _bonusAmount;
    private int _timesCompleted;
    private int _timesToComplete;

    public ChecklistGoal(string name, string description, int points, int timesToComplete, int bonusAmount) : base(name, description, points)
    {
        _timesToComplete = timesToComplete;
        _bonusAmount = bonusAmount;
    }
    public ChecklistGoal(string savedString) : base(savedString)
    {

    }
    public override int RecordEvent()
    {
        return base.RecordEvent();
    }
    public override string ToSavedString()
    {

    }
    public override string ToString()
    {
        return base.ToString();
    }

}