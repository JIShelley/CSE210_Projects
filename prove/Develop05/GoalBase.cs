abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
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
        SetGoalName();
        SetGoalDescription();
        SetGoalPoints();
        _complete = false;
        _goalType = base.ToString();
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
        Console.WriteLine("Please enter how many points your goal is worth: ");
        _points = int.Parse(Console.ReadLine());
    }
    public virtual string GetConsoleString() //Marks the goal as complete with an X and returns the goal information as a string
    {
        string completeString = " ";
        if (_complete)
        {
            completeString = "X";
        }

        return $"[{completeString}] - {_goalType}, Goal Name: {_name}, Description: {_description}, Points: {_points}";
    }

    public int MarkComplete() // Mark the goal as complete and return the points earned
    {
        _complete = true;
        return _points;
    }
    public abstract int RecordEvent();
}