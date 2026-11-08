using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool isRunning = true;

        while (isRunning)
        {
            int choice = menu.DisplayMenu();

            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunBreathingActivity();
                    break;
                case 2:
                    Reflection reflectionActivity = new Reflection();
                    reflectionActivity.RunReflectionActivity();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the program. Goodbye!");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    
    }
}