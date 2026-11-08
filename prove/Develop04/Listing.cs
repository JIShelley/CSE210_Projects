class ListingActivity : BaseActivity
 {
    private List<string> _prompts;
    private List<string> _responses;
    private Random _random = new Random();
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _responses = new List<string>();
    }

    public void RunListingActivity()
    {
        DisplayStartingMessage();
        ObtainDuration();


        DisplayCountdownAnimation("Get Ready", 5);
        int index = _random.Next(_prompts.Count);
        Console.WriteLine("List as many responses as you can for the following prompt:\n");
        Console.WriteLine($"--- {_prompts[index]} ---\n");
        Thread.Sleep(3000);

        RunCountdownMessage("You may begin in", 5);

        Console.WriteLine("List as many responses as you can for the following prompt:\n");
        Console.WriteLine($"--- {_prompts[index]} ---\n");
        _responses.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(response))
            {
                _responses.Add(response);
            }
        }    
        
        Console.WriteLine($"\nYou listed {_responses.Count} items!");
        Thread.Sleep(2000);
        
        DisplayEndingMessage();
    
    }
 }