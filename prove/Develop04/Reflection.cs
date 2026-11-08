class Reflection : BaseActivity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random = new Random();

public Reflection()
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you overcame a significant challenge.",
            "Recall a moment when you achieved something you thought was impossible.",
            "Reflect on a situation where you demonstrated resilience in the face of adversity.",
            "Remember a time when you helped someone in need and made a positive impact.",
            "Think about an experience that taught you an important life lesson."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself from this experience?", 
            "Have you ever done anything like this before?",
            "How can you apply what you learned from this experience in the future?",
            "What strengths did you demonstrate during this experience?",
            "How did this experience change your perspective or beliefs?",
            "What challenges did you face during this experience and how did you overcome them?",
            "What would you do differently if you could go back and do this experience again?",
            "How did this experience impact your relationships with others?"
        };
    }
    
public void RunReflectionActivity()
    {
        DisplayStartingMessage();
        ObtainDuration();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        DisplayCountdownAnimation("Get Ready", 5);
        DisplayRandomPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        RunCountdownMessage("You may begin in", 5);

        while (DateTime.Now < endTime)
        {
            DisplayRandomQuestion();
        }

        DisplayEndingMessage();
    }

    private void DisplayRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {_prompts[index]} ---\n");
    }

    private void DisplayRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        DisplayCountdownAnimation(_questions[index], 10);
    }

}