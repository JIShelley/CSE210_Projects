class ListingActivity : BaseActivity
 {
    private List<string> _prompts;
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
    }

    public void RunListingActivity()
    {
        DisplayStartingMessage();
        ObtainDuration();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        DisplayCountdownAnimation("Get Ready", 5);
        DisplayRandomPrompt();
        
        RunCountdownMessage("You may begin in", 5);

    }

 private void DisplayRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        Console.WriteLine("\nList as many responses as you can for the following prompt:\n");
        Console.WriteLine($"--- {_prompts[index]} ---\n");
    }
}