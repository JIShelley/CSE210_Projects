class BaseActivity
{   
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

    public int ObtainDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        string input = Console.ReadLine();
        int duration;
        while (!int.TryParse(input, out duration) || duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            Console.Write("Enter the duration of the activity in seconds: ");
            input = Console.ReadLine();
        }
        return duration;   
    }

    public void DisplayStartingMessage(string name, string description)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {name} Activity!\n");
        Console.WriteLine(description);
        Console.WriteLine();
    }

    public void DisplayEndingMessage(string name, int duration)
    {
        Console.Clear();
        Console.WriteLine($"Well done!");
        Console.WriteLine($"You have spent {duration} seconds of the {name} activity.");
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}

