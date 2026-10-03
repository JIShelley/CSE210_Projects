using System;

class Program
{
    public static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    public static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    public static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;

    }

    public static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("What is your birth year? ");
        birthYear = int.Parse(Console.ReadLine()); 
    }

    public static int SquareNumber(int favNumber)
    {
        int squared = favNumber * favNumber;
        return squared;
    }

    public static void DisplayResult(string name, int birthYear, int squared)
    {
        int age = DateTime.Now.Year - birthYear;

        Console.WriteLine($"{name}, the square of your number is {squared}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }

    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string name = PromptUserName();

        int favNumber = PromptUserNumber();

        int birthYear; 
        PromptUserBirthYear(out birthYear);

        int squared = SquareNumber(favNumber);
        
        DisplayResult(name, birthYear, squared);
        
    }
}