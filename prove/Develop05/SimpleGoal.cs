class SimpleGoal : CompletableGoal
{
    public override int RecordEvent()
    {
        isCompleted = true;
        return _points;
    }
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public SimpleGoal(string savedString) : base(savedString)
    {

    }

}