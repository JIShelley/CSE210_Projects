using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        int z = 30;

        if (x==10 || y == 21 && z == 30)
        {
            Console.WriteLine("x is 10");
            Console.WriteLine("y is fun");
        }

        else if (x == 20)
        {
            Console.WriteLine("We're in the else if");
        }

        else
        {
            Console.WriteLine("Z is not much fun");
        }
    }
}