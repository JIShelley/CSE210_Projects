class Reflection : BaseActivity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflection()
    {
        
    }
    
    public void RunActivity()
    {
        DisplayStartingMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        int duration = ObtainDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            // Implementation for the reflection activity
        }

        DisplayEndingMessage("Reflection Activity", duration);
    }

    private void SetPromptsAndQuestions()
    {
        
    }

    
}