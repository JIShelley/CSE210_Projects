using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int choice = menu.DisplayMenu();
        bool isRunning = true;

        while (isRunning)
        {
            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunBreathingActivity();
                    break;
                case 2:
                    Reflection reflectionActivity = new Reflection();
                    reflectionActivity.RunActivity();
                    break;
                case 3:
                    // ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    // listingActivity.RunListingActivity();
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