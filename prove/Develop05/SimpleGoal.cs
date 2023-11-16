class SimpleGoal : Goal
{
    public override int RecordEvent()
    {
        return _points;
    }
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public SimpleGoal(string savedString) : base(savedString)
    {

    }

    public override string ToString()
    {
        return $"{GetName()} ({_description})";
    }

    public override string ToSavedString()
    {
        return $"{GetName()}, {_description}, {_points}";
    }

}