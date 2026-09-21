using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);
        
        char letter;
        string sign;

        int lastdigit = percentage % 10;

        if (percentage >= 90)
        {
            letter = 'A';
        }
        else if (percentage >= 80)
        {
            letter = 'B';
        }
        else if (percentage >= 70)
        {
            letter = 'C';
        }
        else if (percentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        if (lastdigit >= 7 && (!(percentage >= 90)) && (!(percentage < 60)))
        {
            sign = "+";
        }
        else if (lastdigit <= 3 && (!(percentage < 60)))
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}!");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("You failed the class. Try again next time!");
        }
    }
}