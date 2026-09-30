using System;

class Program
{
    static void Main(string[] args)
    {
        int PlayAgain = 0;
        
        do{
            Random randomGenerator = new Random();
            int MagicNum = randomGenerator.Next(1,101);
            
            int attempts = 0;
            int Guess = 0;

            do
            {
                Console.Write("What is the Magic Number? ");
                Guess = int.Parse(Console.ReadLine());

                if(MagicNum > Guess)
                {
                    Console.WriteLine("Higher!");
                }
                else if(MagicNum < Guess)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine("That is Correct!");
                }

                attempts++;

            } while (MagicNum != Guess);

            Console.WriteLine($"You finished in {attempts} attempts!");
            Console.Write("Would you like to play again? (y/n) ");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                PlayAgain++;
            }
            else
            {
                PlayAgain = 0;
            }

        } while (PlayAgain != 0);
    }
}