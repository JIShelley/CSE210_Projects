class ChecklistGoal : BaseGoal
{
    private int _timesCompleted;
    private int _maxGoals;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, bool status, int timesCompleted, int max, int bonus)
    : base(name, description, points, status, "Checklist Goal")
    {
        _timesCompleted = timesCompleted;
        _maxGoals = max;
        _bonusPoints = bonus;
    }
    
    public ChecklistGoal() : base("Checklist Goal")
    {
        _maxGoals = ReadInteger("How many times must this goal be completed? ", 1);
        _bonusPoints = ReadInteger("How many bonus points are awarded when the target is reached? ", 0);
    }

    public override string GetConsoleString() //Prints the goal and marks with X if completed
    {
        return $"{base.GetConsoleString()} - Times Completed: {_timesCompleted}/{_maxGoals}";
    }

    public override string GetFileString() //Returns the goal information as a string for saving to a file
    {
        return $"{base.GetFileString()};{_timesCompleted};{_maxGoals};{_bonusPoints}";
    }

    public override int RecordEvent()
    {
        if (_timesCompleted >= _maxGoals)
            return 0;

        _timesCompleted++;

        if (_timesCompleted == _maxGoals)
        {
            MarkComplete();
            return _points + _bonusPoints;
        }
        
        return _points;
    }

    private static int ReadInteger(string prompt, int minimum)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value) && value >= minimum)
                return value;

            Console.WriteLine($"Please enter a whole number greater than or equal to {minimum}.");
        }
    }
}