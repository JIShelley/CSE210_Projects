class EternalGoal : BaseGoal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points, bool status, int timesCompleted)
    : base ( name, description, points, status, "Eternal Goal")
    {
        _timesCompleted = timesCompleted;
    }

    public EternalGoal() : base("Eternal Goal")
    {
    }

    public override string GetConsoleString() //Prints the goal and marks with X if completed
    {
        return $"{base.GetConsoleString()} - Times Completed: {_timesCompleted}";
    }
    
    public override string GetFileString() //Returns the goal information as a string for saving to a file
    {
        return $"{base.GetFileString()};{_timesCompleted}";
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        return _points;
    }
}