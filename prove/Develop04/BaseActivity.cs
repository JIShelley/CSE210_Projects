class BaseActivity
{   
    protected string _name;
    protected string _description;
    protected int _duration;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void RunCountdownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for (int i = seconds; i >= 1; i--)
        {
            Console.Clear();
            Console.Write($"{message} {i}");
            Thread.Sleep(1000);
        }  
        Console.Clear();
        Console.CursorVisible = true;
    }

    public void DisplayCountdownAnimation(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.Write($"{message} ");
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            string spinnerAnimation = "-\\|/";
            int index = 0;
            for (int i=0; i<20; i++)
            {
                Console.Write($"{spinnerAnimation[index++ % spinnerAnimation.Length]}");
                Console.Write("\b");
                Thread.Sleep(300);
            }
        }
        
        Console.Clear();

    }

    public void ObtainDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        string input = Console.ReadLine();
        while (!int.TryParse(input, out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            Console.Write("Enter the duration of the activity in seconds: ");
            input = Console.ReadLine();
        }
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!\n");
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have spent {_duration} seconds of the {_name} activity.");
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}

