using System.Diagnostics.Contracts;

class JournalEntry
{
    public string date;
    public string prompt;
    public string response;
    
    public JournalEntry()
    {    
    }

    public JournalEntry(string entryDate, string entryPrompt, string entryResponse)
    {
        date = entryDate;
        prompt = entryPrompt;
        response = entryResponse;
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{date}, {prompt}");
        Console.WriteLine(response);
    }

    public void CreateJournalEntry()
    {
        string [] prompts =
        {
            "How was your day?",
            "Talk about someone you met",
            "What is one thing you’re grateful for today, and why?",
            "Describe a recent moment that made you feel happy, proud, or peaceful.",
            "What challenge are you currently facing, and what might help you handle it?",
            "If you could give your younger self one piece of advice, what would it be?",
            "What is one goal you want to accomplish, and what is your next small step?",
            "Write about a person who has influenced your life.",
            "What thoughts or emotions have been occupying your mind lately?",
            "Imagine yourself five years from now. What do you hope your life looks like?",
        };

        Random generator = new Random();
        int index = generator.Next(prompts.Length);

        date = DateTime.Now.ToString("MM/dd/yyyy");
        prompt = prompts[index];

        Console.WriteLine($"{prompt}: ");
        Console.Write("> ");

        response = Console.ReadLine();
    }

    public string CreateFileSystemString()
    {
        string outputString = "";
        outputString = $"{date}#{prompt}#{response}";

        return outputString;
    } 
}