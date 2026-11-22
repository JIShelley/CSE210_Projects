class Menu
{
    public void RunMainMenu()
    {
        bool isRunning = true;

        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        
        while (isRunning)
        {
            switch (choice)
            {
                case 1:
                    RunSubMenu();
                    break;
                case 2:
                    // List Goals
                    break;
                case 3:
                    // Save Goals
                    break;
                case 4:
                    // Load Goals
                    break;
                case 5:
                    // Record Event
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


        Console.Clear();
        Console.WriteLine("What kind of goal would you like to make?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Return to Main Menu");
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        while (isRunning)
        {
            switch (choice)
            {
                case 1:
                    SimpleGoal mySimpleGoal = new SimpleGoal();
                    Console.WriteLine(mySimpleGoal.GetConsoleString());
                    break;
                case 2:
                    
                    break;
                case 3:
                    
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