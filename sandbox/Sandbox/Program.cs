using System;

class Program
{
    static double AddNumbers(double x, int y)
    {
        return x + y;
    }
   

    static void DisplayGreeting(string name)
    {
        Console.WriteLine($"Welcome {name}, pleased to meet you!");
    }

   
    static void Main(string[] args)
    {
        DisplayGreeting("Bob");
        double answer = AddNumbers(12.234, 10);
        Console.WriteLine(answer);



    //    bool done = false;

    //    while (!done)
    //    {
    //     Console.Write("Are we done: (y/n): ");
    //     done = Console.ReadLine().ToLower() == "y";
    //    }

    //    bool done;

    //    do
    //    {
    //        Console.Write("Are we done (y/n): ");
    //        done = Console.ReadLine().ToLower() == "y";
    //    } while(!done);

    //    for(int i = 100000; i > 0; i-=5)
    //    {
    //        Console.WriteLine(i);
    //    }

    //    List<string> myFriends = ["Bob", "Betty", "Bubba"];
    //    List<string> names = new List<string>();
    //    myFriends.Add("James");
    //    myFriends.Add("Doug");

    //    foreach(string name in myFriends)
    //    {
    //        Console.WriteLine(name);
    //    }

    }
}