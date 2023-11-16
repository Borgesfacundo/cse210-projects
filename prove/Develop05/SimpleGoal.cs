class SimpleGoal : CompletableGoal
{
    public override int RecordEvent()
    {
        return base.RecordEvent();
    }
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public SimpleGoal(string savedString) : base(savedString)
    {
        
    }
    
}