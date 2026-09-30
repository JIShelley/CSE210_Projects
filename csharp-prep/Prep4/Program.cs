using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers. Type 0 when finished");
        int number = 0;

        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        
        } while(number != 0);

        numbers.Sort();

        int totalSum = numbers.Sum();
        Console.WriteLine($"The sum is: {totalSum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        int smallestPositive = int.MaxValue;
        bool found = false;

        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
                found = true;
            }
        }

        if (found)
        {
            Console.WriteLine($"The smallest positive number is {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers found.");
        }
        
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        
    }
}