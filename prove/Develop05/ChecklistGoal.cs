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
        string[] parts = savedString.Split(",");
        string typeOfGoal = parts[0];
        SetName(parts[1]);
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _bonusAmount = int.Parse(parts[4]);
        _timesCompleted = int.Parse(parts[5]);
        _timesToComplete = int.Parse(parts[6]);
        if (parts[7] == "True")
        {
            isCompleted = true;
        }
        else 
        {
            isCompleted = false;
        }
    }
    public override int RecordEvent()
    {
        _timesCompleted += 1;
        if (_timesCompleted == _timesToComplete)
        {
            Console.WriteLine($"Congratulations! You have earned {_points + _bonusAmount} points!");
            isCompleted = true;
            return _points + _bonusAmount;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }
    }
    public override string ToSavedString()
    {
        return $"{this.GetType().Name},{GetName()},{_description},{_points},{_bonusAmount},{_timesCompleted},{_timesToComplete},{isCompleted}";
    }
    public override string ToString()
    {
        if (isCompleted == true)
        {
        return $"[X] {GetName()} ({_description}) -- Currently completed: {_timesCompleted}/{_timesToComplete}";
        }
        else 
        {
        return $"[ ] {GetName()} ({_description}) -- Currently completed: {_timesCompleted}/{_timesToComplete}";

        }
    }

}