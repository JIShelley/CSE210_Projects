using System;

class Program
{
    static void Main(string[] args)
    {
        // Scripture myScripture = new Scripture("Moses", 1, 39, 
        // "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man.");

        Scripture myScripture = new Scripture("Proverbs", 3, 5, 6, 
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (true)
        {
            Console.Clear();
            myScripture.ShowScripture();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide some words, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }

            bool allHidden = myScripture.HideSomeWords();
            if (allHidden)
            {
                Console.Clear();
                myScripture.ShowScripture();
                Console.WriteLine();
                break;
            
            }
            
        }
        
        
    }
}