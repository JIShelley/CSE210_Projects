class Menu
{
    public int DisplayMainMenu()
    {
        Console.WriteLine("Menu Options");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("Select a choice from the menu: ");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            choice = 0;
        }
        return choice;
    }

    public int DisplaySubMenu()
    {
        Console.WriteLine("What king of goal would you like to make?");
        Console.WriteLine("Simple Goal");
        Console.WriteLine("Eternal Goal");
        Console.WriteLine("Checklist Goal");
        Console.Write("Select a choice from the menu: ");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            choice = 0;
        }
        return choice; 
    }
}