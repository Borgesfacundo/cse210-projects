abstract class CompletableGoal : Goal
{
    protected bool isCompleted;

    protected CompletableGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    protected CompletableGoal(string savedString) : base(savedString)
    {

    }
    public override string ToSavedString()
    {
        return $"{this.GetType().Name}, {GetName()}, {_description}, {_points}, {isCompleted}";
    }
    public override string ToString()
    {
        return $"{GetName()} ({_description})";
    }
}