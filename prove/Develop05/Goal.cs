using System.IO;
class Goal
{
    private List<BaseGoal> _goals;
    private string _filename;
    private int _totalScore;


    public Goal()
    {
        _goals = new List<BaseGoal>();
        _totalScore = 0;
    }

    public void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the name of the file you would like to load?: ");
        _filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_filename);
        if (lines.Length == 0)
        {
            throw new InvalidDataException("The save file is empty.");
        }
        
        _totalScore = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(';');
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool complete = bool.Parse(parts[4]);
            
            BaseGoal goal;
            if (goalType == "Simple Goal")
            {
                goal = new SimpleGoal(name, description, points, complete, goalType);
            }
            else if (goalType == "Eternal Goal")
            {
                int timesCompleted = int.Parse(parts[5]);
                goal = new EternalGoal(name, description, points, complete, timesCompleted);
            }
            else if (goalType == "Checklist Goal")
            {
                int timesCompleted = int.Parse(parts[5]);
                int max = int.Parse(parts[6]);
                int bonus = int.Parse(parts[7]);
                goal = new ChecklistGoal(name, description, points, complete, timesCompleted, max, bonus);
            }
            else
            {
                throw new Exception("Unknown goal type: " + goalType);
            }
            
            _goals.Add(goal); 
        }
    }

    public void SaveGoals()
    {
        if (string.IsNullOrEmpty(_filename))
        {
            Console.Write("What would you like to name this file?: ");
            _filename = Console.ReadLine();
        }

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine(_totalScore);

            foreach (BaseGoal goal in _goals)
            {
                outputFile.WriteLine(goal.GetFileString());
            }
        }
    }

    public void DisplayGoals()
    {
        if (_goals.Count != 0)
        {
            Console.WriteLine("Your Goals are: \n");
            int index = 1;
            foreach (BaseGoal goal in _goals)
            {
                Console.WriteLine($"{index}. {goal.GetConsoleString()}");
                index++;
            }
           
        }   
        else
            Console.WriteLine("You have no goals to list.");

    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_totalScore} points.");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goal to record.");
            return;
        }

        DisplayGoals();
        Console.WriteLine("What goal did you complete?");
        if (!int.TryParse(Console.ReadLine(), out int goalNumber) || goalNumber < 1 || goalNumber > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        int earned = _goals[goalNumber - 1].RecordEvent();
        _totalScore += earned;

        Console.WriteLine($"You have earned {earned} points!");
    
    }
}