class ChecklistGoals : BaseGoal
{
    public ChecklistGoals(string name, string description, int points, bool status, string goalType) 
    : base(name, description, points, status, goalType)
    {
        
    }
    public override int RecordEvent()
    {
        return MarkComplete();
    }
}