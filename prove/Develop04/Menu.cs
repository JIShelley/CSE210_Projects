class Menu
{
    public int DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflection Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            choice = 0;
        }
        return choice;

    }
}