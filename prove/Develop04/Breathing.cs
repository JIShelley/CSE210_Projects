class BreathingActivity : BaseActivity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.")
    {
    }

    public void RunBreathingActivity()
    {
        DisplayStartingMessage();
        ObtainDuration();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        DisplayCountdownAnimation("Get Ready", 5);

        while (DateTime.Now < endTime)
        {
            RunCountdownMessage("Breathe in...", 4);
            RunCountdownMessage("Breathe out...", 6);
        }

        DisplayEndingMessage();
    }
}