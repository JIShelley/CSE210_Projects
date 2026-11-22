using System;

class Program
{
    static void Main(string[] args)
    {
        // mySimpleGoal.RecordEvent();
        // Console.WriteLine(mySimpleGoal.GetConsoleString());
        Console.Clear();

        Goal myGoal = new Goal();
        Menu myMenu = new Menu();
        
        myGoal.DisplayScore();
        Console.WriteLine();
        myMenu.RunMainMenu();
    }
}