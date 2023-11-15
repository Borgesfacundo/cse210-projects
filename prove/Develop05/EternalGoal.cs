class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public EternalGoal(string savedString) : base(savedString)
    {

    }
    public override string ToString()
    {
        return $"{GetName()} {_description} {_points}";
    }
    public override string ToSavedString()
    {
        return $"{GetName}, {_description}, {_points}";
    }
}
