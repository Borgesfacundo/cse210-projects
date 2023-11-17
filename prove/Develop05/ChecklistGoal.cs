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
        _timesCompleted += 1;
        if (_timesCompleted == _timesToComplete)
        {
            isCompleted = true;
            return _points + _bonusAmount;
        }
        else
        {
            Console.WriteLine($"Well done you earned {_points} points!");
            return _points;
        }
    }
    public override string ToSavedString()
    {
        return $"{this.GetType().Name}, {GetName()}, {_description}, {_points}, {_bonusAmount}, {_timesToComplete}, {_timesCompleted}";
    }
    public override string ToString()
    {
        return $"{GetName()} ({_description}) -- Currently completed: {_timesToComplete}/{_timesCompleted}";
    }

}