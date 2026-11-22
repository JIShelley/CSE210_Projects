abstract class BaseGoal
{
    private string _name;
    private string _description;
    protected int _points;
    private bool _complete;
    private string _goalType;

    public BaseGoal(string name, string description, int points, bool complete, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
        _goalType = goalType;
    }

    public BaseGoal(string goalType)
    {   
        Goal myGoal = new Goal();
        SetGoalName();
        SetGoalDescription();
        SetGoalPoints();
        _complete = false;
        _goalType = goalType;
    }

    public void SetGoalName()
    {
        Console.WriteLine("Please enter the name of you goal: ");
        _name = Console.ReadLine();
    }

    public void SetGoalDescription()
    {
        Console.WriteLine("Please describe your goal: ");
        _description = Console.ReadLine();
    }

    public void SetGoalPoints()
    {
        Console.Write("Please enter how many points your goal is worth: ");
        _points = int.Parse(Console.ReadLine());
    }
    public virtual string GetConsoleString() //Prints the goal and marks with X if completed
    {
        string completeString = " ";
        if (_complete)
        {
            completeString = "X";
        }

        return $"[{completeString}] - {_name}, ({_description}) Points: {_points}";
    }

    public virtual string GetFileString() //Returns the goal information as a string for saving to a file
    {
        return $"{_goalType};{_name};{_description};{_points};{_complete}";
    }
    public int MarkComplete() // Mark the goal as complete and return the points earned
    {
        if (_complete)
            return 0;
        
        _complete = true;
        return _points;
    }
    public abstract int RecordEvent();
}