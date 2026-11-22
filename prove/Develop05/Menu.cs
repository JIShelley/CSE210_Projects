class Menu
{
    Goal myGoal = new Goal();
    public void RunMainMenu()
    {
        bool isRunning = true;
        
        while (isRunning)
        {
            Console.WriteLine();
            myGoal.DisplayScore();
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    RunSubMenu();
                    break;
                case 2:
                    myGoal.DisplayGoals();
                    break;
                case 3:
                    myGoal.SaveGoals();
                    break;
                case 4:
                    myGoal.LoadGoals();
                    break;
                case 5:
                    myGoal.RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Thank you for using the program. Goodbye!");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
    public void RunSubMenu()
    {
        bool isRunning = true;
        while (isRunning)
        {
            
        Console.Clear();
        Console.WriteLine("What kind of goal would you like to make?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Return to Main Menu");
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SimpleGoal mySimpleGoal = new SimpleGoal();
                    myGoal.AddGoal(mySimpleGoal);
                    isRunning = false;
                    break;
                case 2:
                    EternalGoal myEternalGoal = new EternalGoal();
                    myGoal.AddGoal(myEternalGoal);
                    isRunning = false;
                    break;
                case 3:
                    ChecklistGoal myChecklistGoal = new ChecklistGoal();
                    myGoal.AddGoal(myChecklistGoal);
                    isRunning = false;
                    break;
                case 4:
                    Console.Clear();
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    Thread.Sleep(2000);
                    break;
            }
        } 
    }
}